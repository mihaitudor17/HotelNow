   M S B A M L   `   `   `  ����K  GHotel management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Hotel_management.ViewsHotel_management.Views  5   	   I)clr-namespace:Hotel_management.ViewmodelsHotel_management.Viewmodels  6<   '    !Hotel_management.Views.OffersView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Hotel_management.Views     5   	   <local1)clr-namespace:Hotel_management.Viewmodels     6<   -   5          � Title$  
OffersView��5   	   $	��450��6   $	��800��6)    � DataContext 5	      *  $Hotel_management.Viewmodels.OffersVM  5
   
   ��5      �� 5   
    �� ImageSource$  /Resources/Background.webp��6   6@   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��personsGrid��5   ,   $��20q�6   $��0��6      AutoGenerateColumns .     
IsReadOnly . $��Visible=�5   %   ��5      �� *Offers+ �� SelectedItem 5      ��  �� Path$ SelectedOffer� �� Mode$ TwoWay=�	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *name+  5      $
 
Start date��6%    69   �� *
start_date+  5      $
 Number of days��6%    6=   �� *number_of_days+  5      $
 Discount��6%    67   �� *price_reduction+5      � 5   
   $��1��6   $��5q�6    � ColumnDefinitions 5       �� 5!      $��* �6#   6/   �� 5"      $��* �6#   6/   .+�5$      �� -   5        $��0��5$      $��Select��6%   $	��100��66   6B   �� 5%   
   -   5        $��1��5%      $��Close��6!   $	��100��61   6=   5&      5'      5(      