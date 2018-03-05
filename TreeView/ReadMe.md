# Chương trình console vẽ cây thư mục

## Nhập vào đường dẫn đến 1 thư mục bất kỳ --> chương trình sẽ vẽ ra sơ đồ cây chi tiết cấu trúc của thư mục đó,bao gồm tất cả các file và thư mục con bên trong

## Cú pháp chạy chương trình: dotnet run [đường dẫn đến thư mục]

## VD: dotnet run /home/moe/Desktop/CSharpProject-master/treeapp/

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

### Sơ lược thuật toán

1. Khởi đầu với thư mục gốc mà người dùng cung cấp

![folder gốc](https://www.lucidchart.com/publicSegments/view/71c8e7e0-e774-4b22-b66e-b637df57b103/image.jpeg)