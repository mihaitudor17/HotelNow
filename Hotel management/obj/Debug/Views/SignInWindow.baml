   M S B A M L   `   `   `  ����K  GHotel management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Hotel_management.ViewsHotel_management.Views  5   	   I)clr-namespace:Hotel_management.ViewmodelsHotel_management.Viewmodels  6<   )    #Hotel_management.Views.SignInWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Hotel_management.Views     5   	   @
viewmodels)clr-namespace:Hotel_management.Viewmodels     6<     � Title$  SignInWindow��5   	   $	��600��6   $	��800��6+    � DataContext 5	      *  $Hotel_management.Viewmodels.SignInVM  5
   
   ��5      �� 5   
    �� ImageSource$  /Resources/Background.webp��6   6@   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $
��0.5* �6   �� 5       $��* �6   �� 5!      $
��0.8* �6   �� 5"      $��* �6   .+�5$   
   �� $��1��6   $��0��6    $��Name:��6-   $��Bottom=�6=   �� 5%   
   $��1��6   $��1��6   $��3��6/   ��6C   �� *	Surname+�� 5&   
   $��1��6   $��2��6    $��	Username:��6-   $��Bottom=�6A   �� 5'   
   $��3��6   $��1��6   $��3��6/   ��6C   �� *
Username+�� 5(   
   $��1��6   $��4��6    $��	Password:��6-   $��Bottom=�6A   �� 5)   
   $��5��6   $��1��6    $��3��60   ��6D   �� *
Password+�� 5*   
   $��1��6   $��6��6    $��Enter password again:��6-   $��Bottom=�6M   �� 5+   
   $��7��6   $��1��6    $��3��60   ��6D   �� *	Password2+�� 5,   
   -   5        $��9��5,      $��0��6   $��3��6.   $��Cancel��5-      $	��150��5.      6   �� 5/   
   -   5        $��9��5/      $��2��6   $��3��6.   $
��Save��50      $	��150��51      6   52      53      