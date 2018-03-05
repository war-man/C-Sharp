# Chương trình console vẽ cây thư mục

## Nhập vào đường dẫn đến 1 thư mục bất kỳ --> chương trình sẽ vẽ ra sơ đồ cây chi tiết cấu trúc của thư mục đó,bao gồm tất cả các file và thư mục con bên trong

Cú pháp chạy chương trình: dotnet run [đường dẫn đến thư mục]
VD: dotnet run /home/moe/Desktop/TreeView

Thuật toán của chương trình:

1. Xây dựng 1 class Info chứa thông tin về:
    - Đường dẫn đến thư mục/file: public string Path
    - Cấp độ của thư mục/file: public int Level
    - Mỗi file/thư mục mà chương trình chọc vào sẽ được đại diện bởi 1 instance của class này

2. Xây dựng 1 method: GetFilesAndDirInOneFolder(folderPath).

Method này có nhiệm vụ chọc vào 1 folder và lấy ra các folder con và file trong folder đó. Lưu ý, method này chỉ chọc vào 1 cấp độ

3. Xây dựng method GetAllFilesAndDir

Đây là method làm nhiệm vụ chính yếu của chương trình: Lấy ra tất cả các file và folder ở tất cả các cấp độ
- Method này sẽ trả về một List<Info>, tức là 1 List các instance của class Info, mỗi instance đại diện cho 1 file/thư mục con
- Ban đầu, List<Info> này sẽ có 1 phần tử là thư mục gốc (Level 0) mà người dùng nhập vào
- Chạy vòng lặp for qua List<Info> này. 
- Ở mỗi lần chạy, ta gọi hàm GetFilesAndDirInOneFolder(folderPath)
- Ở lần chạy đầu tiên, GetFilesAndDirInOneFolder chọc vào folder gốc A/0 (đường dẫn A, cấp độ 0). Ta thực hiện phép kiểm tra xem A/0 có phải là thư mục ko:
    + Nếu là thư mục (trong trường hợp này đương nhiên nó là thư mục :D): 
        + Check xem bên trong nó có file/folder con hay ko:
            + Nếu có thì ta chọc vào và lấy ra được các file và thư mực con. Các file và thư mục con này sẽ được insert vào List tại vị trí ngay sau vị trí của thư mục mà ta vừa chọc vào (trong trường hợp này là thư mục gốc)
            + Nếu ko thì ta ko thêm gì vào List
    + Nếu ko phải là thư mục (tức là file) thì cũng ko thêm gì vào List
- Việc thực hiện phép kiểm tra như trên đảm bảo cho List sẽ ko được liên tục thêm phần tử vào, do đó vòng lặp sẽ ko chạy vô tận
- Các lần chạy vòng lặp tiếp theo diễn ra tương tự.

VD: Chọc vào A/0, lấy ra được 