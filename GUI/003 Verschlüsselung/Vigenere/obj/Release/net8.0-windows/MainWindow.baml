   M S B A M L   `   `   `  ���� I  EVerschluesseln, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VerschluesselnVerschluesseln      Verschluesseln.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:Verschluesseln       � Title$   Vigenère-Verschlüsselung��$	��500��$	��600��
������� � WindowStartupLocation$ CenterScreen=�.���  � ColumnDefinitions �� $��1* ��� $��3* � � RowDefinitions �� $��1* ��� $��35 ��� $��35 ��� $��1* �.+��� -    ��Name$ 	tbEingabe��$�� ��$��0��$��2��$��15(�$��SemiBold"�
�������$��5q�$��Stretch=�$��Stretch=� �� TextWrapping$
 Wrap=��� $��
Code-Wort:��$��1��$��0��$��15(�$��SemiBold"�$��Stretch=�$��Right=�$��Stretch=�$��Center=�$��0,0,10,0q��� -   $ 
tbCodeWort��$
��Code��$��1��$��1��$��15(�
�������$��SemiBold"�$��Stretch=�$
��Left=�$��Stretch=�$��Center=�$��5,0,0,0q�$��5,0,5,0q��� -    ��Name$ cbTyp��$��2��$��2��$��	50,5,50,5q�$��Stretch=�$��Stretch=�$��Center=�
�������
���   �.@��� $��Verschlüsseln�� �� 
IsSelected$
 True���� $��Entschlüsseln���� -   $ 	tbAusgabe��$�� ��$��3��$��2��
�������$��15(�$��SemiBold"�$��5q�$��Stretch=�$��Stretch=�$
 Wrap=� �� 
IsReadOnly$
 True��