   M S B A M L   `   `   `  ����@  <MaDe1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MaDe1MaDe1  5   	       MaDe1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:MaDe1     5   	     � Title$(  "Bài kiểm tra thường xuyên 2��5   	   $	��500��6-   $	��600��6:    � WindowStartupLocation$ CenterScreen=�6F   $��14(�6k   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6   $��2��6-   $��Thông tin khách hàng��6A   
����  �$
��Bold"�6r   $��26(�6�   $��Center=�6�   $��Center=�6�   �� 5   
   $��1��6   $��0��6   $��
Họ tên:��6-      
labelStyle#��[  6?   �� 5   
   -   5        $��txtHoTen��5      $��1��6"   $��1��6/     textBoxStyle#��[ 6?   $
��Left=�6e   $	��300��6�   6�   �� 5   
   $��2��6   $��0��6   $��Giới tính:��6-   #��[  6B   �� 5   
   $��2��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Center=�6K   $��5q�6f   .+�5      	� -   5        $��radNam��5      $	��Nam��6(     radioButtonStyle#��[ 66    d� 	IsChecked$
 TrueY�6`   	� 5       -   5        $��radNu��5       $
��Nữ��6'   #��[ 64   5!      �� 5#   
   $��3��6   $��0��6   $��Số lượng mua:��6-   #��[  6E   �� 5$   
   -   5        $��txtSoLuongMua��5$      $��3��6'   $��1��64   #��[ 6D   $
��Left=�6j   $	��100��6�   6�   �� 5&   
   $��4��6   $��0��6   $��Đơn giá:��6-   #��[  6@   �� 5'   
   -   5        $��	txtDonGia��5'      $��4��6#   $��1��60   #��[ 6@   $
��Left=�6f   $	��100��6�   6�   �� 5)   
   $��5��6   $��0��6   $��Danh sách khách hàng:��6-   $��2��6M   #��[  6a   &   System.Windows.Controls.DataGrid  5+   
   $��6��6   $��0��6    $��2��60   $��10, 0, 10, 0q�6D      AutoGenerateColumns$ False��6Z     columnHeaderStyle   ColumnHeaderStyle# [ 6v      Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Họ và tên��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *HoTen+6^     5.      $	 Giới tính��6%   $

 0.6* 6U    68   �� *
GioiTinh+6d     5/      $	 Số lượng mua��6%   $
 * 6Z    6;   �� *
SoLuongMua+6f     50      $	 
Đơn giá��6%   $
 * 6Q    66   �� *DonGia+6]     51      $	 Thành tiền��6%   $
 * 6W    69   �� *	ThanhTien+6c   53      �� 55   
   $��7��6   $��0��6    $��2��60   $��Center=�6D   $��Chức năng��6a   
�������$��0,0,0,10q�6�   $	��400��6�   .��56      �� $ 
Horizontal=�6   $��Center=�62   .+�57      �� -   5        $��btnThem��57      $��Thêm��6>     buttonStyle#��[ 6M   6t   �� 58      -   5        $��
btnWindow2��58      $��Window 2��6D   #��[ 6W   6~   59      5:      5;      5<      