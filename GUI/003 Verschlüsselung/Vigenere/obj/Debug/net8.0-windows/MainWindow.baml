   M S B A M L   `   `   `  ����I  EVerschluesseln, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VerschluesselnVerschluesseln  5   	       Verschluesseln.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Verschluesseln     5   	     � Title$  Caesar-Verschlüsselung��5   	   $	��500��6(   $	��600��65   
������� � WindowStartupLocation$ CenterScreen=�6S   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��35 �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ 	tbEingabe��5      $�� ��6%   $��0��6-   $��2��6:   $��15(�6N   $��SemiBold"�6\   
�������$��5q�6�   $��Stretch=�6�   $��Stretch=�6�    �� TextWrapping$
 Wrap=�6�   6�   �� 5   
   -   5         ��Name$ 	slVersatz��5      $��1��6$   $��5,0,5,0q�61   $��Stretch=�6B   $��Stretch=�6^    �� TickFrequency$ 1Q�6|    � Minimum$ 1Q�6�   	 � Maximum$	 26Q�6�   
�������$��Center=�6�   
 �� TickPlacement$
 BottomRight=�6�    �� IsSnapToTickEnabled$
 True��6�   6  �� 5   
   -   5         ��Name$ slValue��5      $��A��6!   
�������$
��Bold"�6@   $��1��6R   $��1��6_   $��Stretch=�6o   $��Stretch=�6�   $��Center=�6�   $��Center=�6�   $��0q�6�   �� 5   
   -   5         ��Name$ cbTyp��5      $��2��6"   $��2��6/   $��	50,5,50,5q�6C   $��Stretch=�6V   $��Stretch=�6r   $��Center=�6�   
�������
�������.@�5      �� $��Verschlüsseln��6    �� 
IsSelected$
 True��63   �� 5      $��Entschlüsseln��6   5      �� 5   
   -   5        $ 	tbAusgabe��5      $�� ��6%   $��3��6-   $��2��6:   
�������$��15(�6e   $��SemiBold"�6s   $��5q�6�   $��Stretch=�6�   $��Stretch=�6�   $
 Wrap=�6�    �� 
IsReadOnly$
 True��6�   5       5!      