   M S B A M L   `   `   `  ����K  GHotel management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Hotel_management.ViewsHotel_management.Views  5   	   I)clr-namespace:Hotel_management.ViewmodelsHotel_management.Viewmodels  6<   -    'Hotel_management.Views.EditFeaturesView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Hotel_management.Views     5   	   @
viewmodels)clr-namespace:Hotel_management.Viewmodels     6<     � Title$  EditFeaturesView��5   	   $	��450��6"   $	��500��6/   ��5	      �� 5
   
    �� ImageSource$  /Resources/Background.webp��6   6@   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��personsGrid��5       $��7��6   $��0,15,0,0q�63   $	��250��6E      AutoGenerateColumns .     
IsReadOnly . $��Visible=�5   A   ��5      �� *
Features+ �� SelectedItem 5      ��  �� Path$ SelectedFeature� �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 63   �� *name+  5      $	 Price��6%   
 64   �� *price+5      �� 5   
   $��0��6   $��Name:��6   �� 5   
   $��1��6   ��6   �� *SelectedFeature.name+�� 5    
   $��2��6   $��Price:��6   �� 5!   
   $��3��6   ��6   �� *SelectedFeature.price+�� 5"   
   $��4��6    �� Orientation$ 
Horizontal=�6"   .+�5#      �� -   5        $	��Add��5#      $��50, 0, 0, 0q�6#   $	��100��68   6D   �� 5$      -   5        $��Modify��5$      $��50, 0, 0, 0q�6&   $	��100��6;   6G   �� 5%      -   5        $��Delete��5%      $��50, 0, 0, 0q�6&   $	��100��6;   6G   5&      5'      5(      