   M S B A M L   `   `   `  ����K  GHotel management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Hotel_management.ViewsHotel_management.Views  5   	   I)clr-namespace:Hotel_management.ViewmodelsHotel_management.Viewmodels  6<   +    %Hotel_management.Views.BookRoomWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Hotel_management.Views     5   	   @
viewmodels)clr-namespace:Hotel_management.Viewmodels     6<     � Title$  BookRoomWindow��5   	   $	��450��6    $	��800��6-   ��5	      �� 5
   
    �� ImageSource$  /Resources/Background.webp��6   6@   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��15* �6   �� 5      $	��15* �6   �� 5      $��* �6   �� 5      $	��15* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��4* �6   �� 5      $
��auto �6   �� 5      $��4* �6   �� 5      $��* �6   .+�5   
   �� $��From:��6   $��Center=�6!   $��Bottom=�6>   $��SemiBold"�6Y   $��20(�6o   6   &   System.Windows.Controls.Calendar  5   
   -   5        $��Calendar��5       $��1��6   $y�Visible=�6N      SelectedDate 60   �� *Date+6N   �� 5   
   -   5        $��	DaysLabel��5      $��2��6%   $��Number of days:��62   $��Center=�6I   $��Bottom=�6f   $��SemiBold"�6�   $��20(�6�   6�   �� 5   
   $��3��6   
�������$��10q�65   ._�5   
   �� -   5        $��DaysTextBox��5      $y�Visible=�6C   $��15(�6X   $��Stretch=�6f   $��10q�6�   $��Center=�6�   ��6%   �� *NumberOfDays+6�   5      �� 5    
   -   5        $��4��5       $��	30 5 30 5q�6   $��Deals��5!      6!   �� 5"   
   $��1��6   $��2��6$   $��	Features:��61   $��Center=�6B   $��Bottom=�6_   $��SemiBold"�6z   $��20(�6�   6�   �� 5#   
   -   5        $��ListBox��5#      $��10q�6   $��3��6-   $��1��6:    �� DisplayMemberPath$ Item1��5$      ��5#   J   �� *
Features+ �� SelectedItem 5%      �� *SelectedFeature+6>   �� 5&   
   -   5        $��4��5&      $��1��6   $��	30 5 30 5q�6/   $	��Add��5'      6   �� 5(   
   $��5q�6   $��2��6   $��5��6/   $��Stretch=�6@   
�������$��2��6m   $��Center=�6w   �� 5)   
   $��3��6   $��Price:��6$   $��Center=�62   $��Bottom=�6O   $��SemiBold"�6j   $��20(�6�   6�   �� 5*   
   
�������$��1��6+   $��3��68   $	��Top=�6H   6b   �� 5+   
   $��1��6   $��3��6   
�������._�5,   
   �� $��Center=�6,   $��20(�6G   $��SemiBold"�6U   $��Center=�6k   ��6   �� *Price+6�   5-      � 5.      $��3��6   $��3��6     5/      �� 50      $��* �6    6-   �� 51      $��* �6    52      .+�54      �� -   5        $��20q�54      .��55      �  56      �� 57      $��* �6'   �� 58      $��2* �6'   .+�5:      �� $��/Resources/buy.png��6   $��0��64   6F   �� 5;      $��1��6   $��Center=�6,   $��25(�6G   $��SemiBold"�6U   
Book now6u   5<      5=      �� 5>      -   5        $��1��5>      $��X     Cancel��6"   $��25(�69   $��SemiBold"�6G   $��20q�6]   6�   5?      �� 5@   
   $��0��6   $��1��6!   $��Deals:��61   $��Center=�6?   $��Bottom=�6\   $��SemiBold"�6w   $��20(�6�   6�   �� 5A   
   $��1��6   $��1��6   
�������._�5B   
   �� -	   5        $��
OfferPanel��5B      .+�5C      �� ��6   �� *
Offer.name+5D      5E      5V      5W      