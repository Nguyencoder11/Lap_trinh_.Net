   M S B A M L   `   `   `  ����C  ?BaiTap91, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BaiTap91BaiTap91  5   	       BaiTap91.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:BaiTap91     5   	     � Title$  Chọn sách��5   	   $	��450��6   $	��800��6(    � WindowStartupLocation$ CenterScreen=�64   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��
Danh sách��6   $��0��6$   $��0��61   6C   �� 5   
   $��Sách đã chọn��6   $��0��6'   $��2��64   6F   �� 5   
   -   5         ��Name$ lstDanhSach��5      $��1��6'   $��0��64   $��10q�6D   6R   �� 5   
   $��1��6   $��1��6"   $��10q�62   $��Center=�6>   .+�5      �� -   5         ��Name$ btnThem��5   I   $��>��6      buttonStyle#��[  6$   6r   �� 5      -   5        $ 
btnThemHet��5   M   $��>>��6   #��[  6(   6|   �� 5      -   5        $ btnBo��5   I   $��<��6   #��[  6$   6n   �� 5      -   5        $ btnBoHet��5   M   $��<<��6   #��[  6(   6x   5      �� 5   
   -   5        $ 	lstDaChon��5      $��1��6%   $��2��62   $��10q�6B   6P   �� 5   
   $��2��6   $��0��6"   $��3��62    �� Orientation$ 
Horizontal=�6F   $��Right=�6_   $��0,8,0,8q�6{   .+�5      �� -   5        $ btnThoat��5      $��Thoát��6>   #��[  6N   6u   5       5!      5"      