   M S B A M L   `   `   `  ����M  IBai12_Nguyen114_P1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Bai12_Nguyen114_P1Bai12_Nguyen114_P1  5   	   #    Bai12_Nguyen114_P1.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Bai12_Nguyen114_P1     5   	     � Title$   Quản lý bán hàng v1.0��5   	   $	��200��6'   $	��500��64    � WindowStartupLocation$ CenterScreen=�6@   $��16(�6e   .��5	      � $��20,10,20,10q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Tên đăng nhập��6      
labelStyle#��[  65   6[   �� 5   
   -   5         ��Name$ txtTenDangNhap��5      $��0��6*   $��1��67     textBoxStyle#��[ 6G   �� 5   
   $��1��6   $��Mật khẩu��6   #��[  60   6V   �� 5   
   -   5        $ 
txtMatKhau��5      $��1��6&   $��1��63   #��[ 6C   �� 5   
   $��2��6   $��2��6"   $��Center=�66   $��Center=�6S   .+�5      �� -   5         ��Name$ btnDangNhap��5      $��Đăng nhập��6*     btnStyle#��[ 6X   5      5      5      