@echo off
:: Lấy Ngày, Tháng, Năm độc lập với định dạng vùng của Windows
for /f "tokens=2 delims==" %%I in ('wmic os get localdatetime /value') do set datetime=%%I
set YYYY=%datetime:~0,4%
set MM=%datetime:~4,2%
set DD=%datetime:~6,2%

:: Tạo tên thư mục Backup theo định dạng Năm_Tháng_Ngày (ví dụ: Backup_2026_07_04)
set "BACKUP_DIR=Backup_%YYYY%_%MM%_%DD%"

:: 1. TẠO THƯ MỤC BACKUP THEO NGÀY
mkdir "%BACKUP_DIR%" 2>nul

:: 2. BACKUP CÁC FILE CŨ VÀO ĐÚNG CẤU TRÚC
xcopy "BaoCaoMau\Kho\bangkexuathang*.xls" "%BACKUP_DIR%\BaoCaoMau\Kho\" /I /Y
xcopy "VNS.ERP.GUI.dll" "%BACKUP_DIR%\" /I /Y

echo --- ĐÃ BACKUP VÀO THƯ MỤC %BACKUP_DIR% ---