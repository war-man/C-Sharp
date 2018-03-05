# Chương trình console vẽ cây thư mục

## Nhập vào đường dẫn đến 1 thư mục bất kỳ --> chương trình sẽ vẽ ra sơ đồ cây chi tiết cấu trúc của thư mục đó,bao gồm tất cả các file và thư mục con bên trong

## Cú pháp chạy chương trình: dotnet run [đường dẫn đến thư mục]

## VD: dotnet run /home/moe/Desktop/CSharpProject-master/treeapp/

```
├ folderA
│ ├ folderAA
│ │ ├ Foo
│ │ │ ├ manual.txt
│ │ ├ rock.js
│ │ ├ foo.js
│ ├ something.txt
│ ├ anotherfile.dart
├ folderB
│ ├ delete.cs
│ ├ add.cs
├ amend.cs
├ hello.csproj
├ file.cs
├ ReadMe.md
```

### Sơ lược thuật toán

### Chú thích

Tên folder in hoa, tên file viết thường

Sau tên file, folder là số chỉ cấp độ

VD: A/0 là folder A cấp độ 0, b/1 là file b cấp độ 1

Những file và folder cùng cấp độ sẽ được tô cùng màu

1. Khởi đầu với folder gốc A/0 mà người dùng cung cấp

![A/0](https://www.lucidchart.com/publicSegments/view/6ff4bb20-5300-4d33-b55a-d39de455228a/image.png)

2. Chọc vào A/0

Tiến hành check:

  * Nếu A/0 là file: Ko làm gì cả
  * Nếu A/0 là folder:
    * Nếu folder rỗng: Ko làm gì cả
    * Folder ko rỗng: Lấy các file và folder trong A/0, chèn bọn nó vào vị trí ngay đằng sau folder vừa chọc vào (A/0)

![A/0, B/1, C/1,d/1](https://www.lucidchart.com/publicSegments/view/35e08fc3-4589-4dfe-9b26-1de4f1139aea/image.png)