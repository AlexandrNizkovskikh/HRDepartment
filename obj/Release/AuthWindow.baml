   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.AuthWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1       � Title$  Авторизация��$	��500��$	��600�����	#FF404040 � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � 	Resources    TopMenuButtons �� 
TargetType �� 
TargetType �� Property �� Value �� Triggers	 �� Binding
 �� Path �� ElementName �� Value  Buttons  TopMenuButton��%�  &	        &	 �     &	 �    �� " ��.R�� $	��Btn��.+��� ._�� .+��� #��z��
������ $��Center=����� " ��.���  � �� �	#FF597CAE �� 	 �� $
 IsMouseOver�$	 Btn�� True.a���  � ��
 ������� " ��.R�� $	��Btn��.+��� ._�� .+��� #��z��$��16(�
������ $��Center=����� " ��.���  � �� �	#FF8E8E8E �� 	 �� $
 IsMouseOver�$	 Btn�� True.a���  � �� �	#FFB0C4DE�� " ��.R�� $	��Btn��.+��� ._�� .+��� #��z��
������ $��Center=����� " ��.���  � �� �	#FF818181 �� 	 �� $
 IsMouseOver�$	 Btn�� True.a���  � �� �	#FFBDBDBD.��� .+�� $��2,1,0,2q�$
��Left=�$	��600�� � ColumnDefinitions ��  � RowDefinitions �� $��50 ��� $��50 ��� $��* ��� $��50 �.+��� $��АВТОРИЗАЦИЯ��$��45(�$��0��$
��Left=�$��	192,8,0,0q�$��Bahnschrift Condensed)�$
��Bold"�$	��222�����	#FF597CAE� $��2��$��Center=�$	��Top=�$��0,68,0,0q�$	��386��$	��158�� �� $��40 ��� $��40 ��� $��60 � �� $	��100 ��� $��* �.+��� $��Логин:��$��0��$��0��$��30(�$��Bahnschrift Condensed)�
�������$��28,0,2,0q��� -    ��Name$ TextBoxLogin��$��3,0,3,0q�$��Center=����	#FF171B21$��28��$��Bahnschrift Condensed)����	#FF909090$��20(�$��1����  J� IsHitTestVisible .  $��20(�$��
Логин��$��6,0,6,0q�$��Center=����	#FF909090$��24��$��Bahnschrift Condensed)�$��1������ " ��.���  � y�$ 	Collapsed=� �� 	 �� *Text+$ TextBoxLogin��  .a���  � y�$ Visible=��� -   $ TextBoxPassword��$��1��$��3,0,3,0q�$��Center=����	#FF171B21$��28��$��Bahnschrift Condensed)����	#FF909090$��20(�$��1����  .  $��20(�$��Пароль��$��1��$��6,0,6,0q�$��Center=����	#FF909090$��24��$��Bahnschrift Condensed)�$��1������ " ��.���  � y�$ 	Collapsed=� �� 	 �� *Text+$ TextBoxPassword��  .a���  � y�$ Visible=��� $��0��$��0��$��30(�$��Bahnschrift Condensed)�
�������$��	15,39,5,1q�$��2���� $�П���� $�а���� $�роль����  � Language$ ru-ru�$�:���� -    ��Name$ BtnLogin��#��[  $"��АВТОРИЗОВАТЬСЯ��$��2�� � Cursor$
 Hand��$��25(�$
��Bold"�$��18,37,112,-19q�$��Bahnschrift Condensed)����	#FF597CAE$��1����Z� ��Z� 