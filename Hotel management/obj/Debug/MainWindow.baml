   M S B A M L   `   `   `  ����K  GHotel management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Hotel_managementHotel_management  5   	   I)clr-namespace:Hotel_management.ViewmodelsHotel_management.Viewmodels  66   !    Hotel_management.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Hotel_management     5   	   @
viewmodels)clr-namespace:Hotel_management.Viewmodels     66     � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)    � DataContext 5	      )  #Hotel_management.Viewmodels.LoginVM  5
   
   ��5      �� 5   
    �� ImageSource$  /Resources/Background.webp��6   6@   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $
��0.8* �6   �� 5       $��* �6   �� 5!      $
��0.8* �6   �� 5"      $��* �6   .+�5$   
   �� $��2��6   $��1��6   $��	Username:��6-   $��Bottom=�6A   �� 5%   
   $��3��6   $��1��6   $��3��6/   ��6C   �� *	Surname+�� 5&   
   $��1��6   $��4��6    $��	Password:��6-   $��Bottom=�6A   G� 5'   
   -   5        $��5��5'      $��1��6#   $��3��63   6G   �� 5(   
   -   5        $��7��5(      $��1��6   $��Log in��6.   6?   �� 5+   
   -   5        $��7��5+      $��3��6   $��Sign in��6.   6@   �� 5,   
   $��8��6   $��2��6!   67   �� 5-   
   $��8��6   $��2��6!   $��Center=�61   $��Center=�6L   $��20(�6i   $��SemiBold"�6w   OR6�   �� 5.   
   $��8��6   $��3��6!   $��2��61   6G   �� 5/   
   -   5        $��9��5/      $��1��6   $��3��6.   $��Continue As Guest��50      $	��150��51      6   52      53      