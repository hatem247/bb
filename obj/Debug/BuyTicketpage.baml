   M S B A M L   `   `   `  ����D  @AirportMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AirportMS	AirportMS  5          AirportMS.BuyTicketpage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:AirportMS     5        N� Title$  BuyTicketpage��5	      .��5      � ��5   
   �� 5       �� ImageSource$ AirportBackground.jpg��6    � ColumnDefinitions 5   
   �� 5      $��90 �6   �� 5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��1��6   ���#E52B50$��38(�6B   $
��Bold"�6P   $��25,0,0,0q�6b   $��Trebuchet MS)�6t   .��6�   	Airport6�   �� 5   
   $��0��6   $��1��6   ���#E52B50$��30(�6B   $
��Bold"�6P   $��	15,50,0,0q�6b   $��Trebuchet MS)�6u   .��6�   
Buy Ticket6�   �� 5   
   $��1��6   $��0��6   ���#E52B50.��6B   Name:6I   �� 5   
   -   5        $��PassengerNametxtbox��5      ���#E52B50$��1��6C   $��1��6P   $��	0,3,100,3q�6`   ���#E52B50
������ 6�   �� 5   
   $��2��6   $��0��6   ���#E52B50.��6B   Seat Number6O   �� 5   
   $��3��6   $��0��6   ���#E52B50.��6B   Ticket Price6P   �� 5    
   -   5        $��SeatNumbertxtbox��5       ���#E52B50$��2��6@   $��1��6M   $��	0,3,100,3q�6]   ���#E52B50
������ 6�   �� 5!   
   -   5        $��TicketPriceCompobox��5!      ���#E52B50$��3��6D   $��1��6Q   $��	0,3,200,3q�6a   ���#E52B50
������ .@�5"      �� .��6   2006    �� 5#      .��6   1806    �� 5$      .��6   1506    �� 5%      .��6   1206    �� 5&      .��6   1006    �� 5'      .��6   806   �� 5(      .��6   506   5)      �� 5*   
   -   5        $��
Confirmbtn��5*      ���#E52B50$��1��69   $��8��6I   $��160,35,20,110q�6V   ���#E52B50
������ .��6�   	Confirm6�   �� 5+   
   -   5        $��	Deletebtn��5+      ���#E52B50$��1��68   $��8��6H   $��160,60,20,85q�6U   ���#E52B50
������ .��6�   Cancel6�   5,      5-      