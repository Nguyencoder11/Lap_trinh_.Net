   M S B A M L   `   `   `  ����C  ?MinhHoa2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MinhHoa2MinhHoa2  5   	       MinhHoa2.Window2   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MinhHoa2     5   	     � Title$'  !Danh sach nhan vien lon tuoi nhat��5   	   $	��450��63   $	��800��6@   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dtgNhanVienMaxTuoi��5
         AutoGenerateColumns$ False��6/      columnHeaderStyle   ColumnHeaderStyle# [  6K   $��12,10,12,10q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã nhân viên��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *MaNV+6`     5      $ 	Họ tên��6%   $
 1.8* 6O    65   �� *HoTen+6^     5      $ Giới tính��6%   $ * 6U    68   �� *
GioiTinh+6a     5      $ 
Phòng ban��6%   $
 1.2* 6U    68   �� *
PhongBan+6d     5      $ 
Ngày sinh��6%   $
 1.1* 6n    68   �� *
NgaySinh+ �� StringFormat$ 
dd-MM-yyyy��6}     5      $ Tuổi��6%   $ * 6L    63   �� *Tuoi+6X   5      5      5      