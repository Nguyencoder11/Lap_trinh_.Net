   M S B A M L   `   `   `  ����C  ?MinhHoa2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MinhHoa2MinhHoa2  5   	       MinhHoa2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MinhHoa2     5   	     � Title$  Bài kiểm tra tx2��5   	   $	��650��6"   $	��700��6/    � WindowStartupLocation$ CenterScreen=�6;   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��23* �6   �� 5      $	��77* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6   $��2��6-   $��Center=�6A   $��Center=�6^   $'��!Quản lý thông tin nhân viên��6y   $��22(�6�   $��SemiBold"�6�   
����  �$��0,20,0,0q�6�   �� 5   
   $��1��6   $��0��6   $��2��6.   $��7��6B   $��5,0,5,0q�6S   
�������
��� � �$��2q�6�   �� 5   
   $��1��6   $��0��6   $��Mã nhân viên:��6-      
labelStyle#��[  6E   �� 5   
   -   5         ��Name$ txtMaNV��5      $��1��6#   $��1��60     textBoxStyle#��[ 6@   $
��Left=�6f   $	��150��6�   �� 5"   
   $��2��6   $��0��6   $��
Họ tên:��6-   #��[  6?   �� 5#   
   -   5        $ txtHoTen��5#      $��2��6$   $��1��61   #��[ 6A   $
��Left=�6g   $	��250��6�   �� 5&   
   $��3��6   $��0��6   $��Ngày sinh:��6-   #��[  6B   (  "System.Windows.Controls.DatePicker  5'   
   -   5        $��dtpNgaySinh��5'      $��3��6(   $��1��65   $
��Left=�6E   $��
10,10,8,10q�6`   $	��150��6t   $��16(�6�   6�   �� 5*   
   $��4��6   $��0��6   $��Giới tính:��6-   #��[  6B   �� 5+   
   $��4��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��10,8,8,8q�6K   .+�5,      	� -   5        $��radNam��5,      $	��Nam��6(     radioButtonStyle#��[ 66   	� 5-      -   5        $��radNu��5-      $
��Nữ��6'   #��[ 64   5.      �� 51   
   $��5��6   $��0��6   $��Phòng ban:��6-   #��[  6B   �� 52   
   -   5         ��Name$ cboPhongBan��52      $��5��6(   $��1��65     comboBoxStyle#��[ 6E   $
��Left=�6l    �� SelectedIndex$ 0��6�   $	��200��6�   .@�53      �� .��6   Tổ chức6$   �� 54      .��6   Kế hoạch6%   �� 55      .��6   	Vật tư6#   56      �� 59   
   $��6��6   $��0��6   $��Hệ số lương:��6-   #��[  6D   �� 5:   
   -   5        $ txtHeSoLuong��5:      $��6��6(   $��1��65   #��[ 6E   $
��Left=�6k   $	��150��6�   &   System.Windows.Controls.DataGrid  5=   
   -   5          Name$ dtgNhanVien��5=      $��7��6(   $��0��65   $��2��6E   	   AutoGenerateColumns$	 False��6Y     columnHeaderStyle
   ColumnHeaderStyle#
 [ 6u   $��12,10,12,10q�6�      Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã nhân viên��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *MaNV+6`     5@      $ 	Họ tên��6%   $
 1.8* 6O    65   �� *HoTen+6^     5A      $ Giới tính��6%   $ * 6U    68   �� *
GioiTinh+6a     5B      $ 
Phòng ban��6%   $
 1.2* 6U    68   �� *
PhongBan+6d     5C      $ 
Ngày sinh��6%   $
 1.1* 6n    68   �� *
NgaySinh+ �� StringFormat$ 
dd-MM-yyyy��6}     5D      $ Tuổi��6%   $ * 6L    63   �� *Tuoi+6X   5F      �� 5I   
   $��8��6   $��0��6"   $��2��62   $ 
Horizontal=�6F   $��Center=�6_   $��8q�6|   .+�5J      �� -	   5         ��Name$ btnNhap��5J      $��Nhập��6&     buttonTemplate#��[ 65     buttonStyle#��[ 6`   6�   �� 5K      -
   5        $ 
btnWindow2��5K      $��Window 2��6)   #��[ 6<   #��[ 6g   6�   5L      5M      5N      