# Kiểm thử chính sách định khoản kho từ 01/01/2026

## Trình tự

1. Clone database Production sang database kiểm thử.
2. Chạy `StockAccountingPolicy_20260101.sql` trên database clone.
3. Trỏ bản App mới vào database clone.
4. Sao lưu kết quả truy vấn trước và sau mỗi ca kiểm thử.
5. Chỉ triển khai Production sau khi kế toán xác nhận các bút toán và báo cáo.

## Ca sinh định khoản

| Nghiệp vụ | Ngày chứng từ | Kết quả cần có |
|---|---|---|
| N11 | 31/12/2025 | Nợ 6111 / Có 331 |
| N11 | 01/01/2026 | Nợ 152 / Có 331 |
| N21 | 31/12/2025 | Nợ 632x / Có 6311 |
| N21 | 01/01/2026 | Nợ 155 / Có 154 |
| X11 | 31/12/2025 | Nợ 621 / Có 6111 |
| X11 | 01/01/2026 | Nợ 621 / Có 152 |
| X14 | 31/12/2025 | Nợ 632 / Có 6111 |
| X14 | 01/01/2026 | Nợ 632 / Có 152 |
| Xuất thành phẩm | 31/12/2025 | Có 63211/63212/63213 theo loại |
| Xuất thành phẩm | 01/01/2026 | Có 155 |

Kiểm tra cả hai đường thao tác: chọn phiếu kho từ màn hình định khoản và mở định khoản trực tiếp từ chi tiết phiếu kho.

## Khóa sổ và dữ liệu cũ

- Ghi lại số dòng và tổng tiền của kỳ đã khóa trước khi test.
- Thử sửa, xóa và tính lại kỳ đã khóa; App phải tiếp tục từ chối như phiên bản hiện tại.
- Sau toàn bộ test, số dòng và tổng tiền của kỳ đã khóa phải không đổi.
- Chứng từ đã tồn tại không được tự động đổi tài khoản khi mở xem.
- Chỉ khi người dùng chủ động sinh mới/sinh lại trong kỳ chưa khóa thì logic theo ngày chứng từ mới được áp dụng.

## Báo cáo

| Khoảng ngày | Tài khoản truyền | Kết quả |
|---|---|---|
| Kết thúc trước 01/01/2026 | 6111 hoặc 632x | Chạy báo cáo cũ |
| Bắt đầu từ 01/01/2026 | 152 hoặc 155 | Chạy báo cáo mới |
| Đi qua 01/01/2026 | Bất kỳ | Giao diện cảnh báo và không chạy |
| Kỳ cũ nhưng chọn 152/155 | 152 hoặc 155 | Giao diện cảnh báo |
| Kỳ mới nhưng chọn 6111/632x | 6111 hoặc 632x | Giao diện cảnh báo |

## Giá xuất kho

- Chạy tính giá nguyên vật liệu cho một kỳ 2025 chưa khóa trên DB clone: dữ liệu nguồn phải được lọc theo 6111.
- Chạy tính giá nguyên vật liệu cho kỳ 2026 chưa khóa: dữ liệu nguồn phải được lọc theo 152.
- Thực hiện tương tự với thành phẩm: 632x trước 2026 và 155 từ 2026.
- Đối chiếu tổng `CostAmount` ở chi tiết kho với tổng tiền trên `AccountTransactionDetail1s` và `AccountTransactionDetail2s`.

## Điều kiện đạt

- Không có dữ liệu kỳ khóa bị thay đổi.
- Không có bút toán mới nào trộn tài khoản cũ và mới trong cùng chứng từ.
- Báo cáo cũ và mới khớp dữ liệu chi tiết của từng kỳ riêng biệt.
- Các tổng số lượng, giá trị nhập, xuất và tồn cân đối trước khi triển khai Production.

