   M S B A M L   `   `   `  ����K  GHotel management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Hotel_management.ViewsHotel_management.Views  5   	   I)clr-namespace:Hotel_management.ViewmodelsHotel_management.Viewmodels  6<   &     Hotel_management.Views.AdminView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Hotel_management.Views     5   	   @
viewmodels)clr-namespace:Hotel_management.Viewmodels     6<     � Title$  	AdminView��5   	   $	��800��6   $	��800��6(   ��5	      �� 5
   
    �� ImageSource$  /Resources/Background.webp��6   6@    � DataContext 5      )  #Hotel_management.Viewmodels.AdminVM  5   
   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��Name:��6    $��Bottom=�60   �� 5   
   $��1��6   $��1��6   $��3��6/   ��6C   �� *SelectedUser.name+�� 5   
   $��2��6   $��1��6   $��Surname:��6-   $��Bottom=�6@   �� 5    
   $��3��6   $��1��6   $��3��6/   ��6C   �� *SelectedUser.surname+�� 5!   
   $��1��6   $��4��6    $��	Password:��6-   $��Bottom=�6A   �� 5"   
   $��5��6   $��1��6   $��3��6/   ��6C   �� *SelectedUser.password+�� 5#   
   $��1��6   $��6��6    $��Type:��6-   $��Bottom=�6=   �� 5$   
   $��7��6   $��1��6   $��3��6/   ��6C   �� *SelectedUser.type+�� 5%   
   -   5        $��9��5%      $	��100��6   $
��Left=�6*   $	��Add��6E   6S   �� 5&   
   -   5        $��9��5&      $	��100��6   $��Center=�6*   $��Modify��6G   6X   �� 5'   
   -   5        $��9��5'      $	��100��6   $��Right=�6*   $��Delete��6F   6W   &   System.Windows.Controls.DataGrid  5(   
   -   5        $��personsGrid��5(   !   $��10��6   $��0,15,0,0q�64   $	��250��6F      AutoGenerateColumns .     
IsReadOnly . $��Visible=�5)   A   ��5*      �� *Users+ �� SelectedItem 5+      ��  �� Path$ SelectedUser� �� Mode$ TwoWay=�	   Columns	 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *name+  5.      $
 Surname��6%    66   �� *	surname+  5/      $
 Password��6%    67   �� *
password+  50      $

 Type��6%    63   �� *type+52      53      54      