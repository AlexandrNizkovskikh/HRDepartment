   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1       � Title$  Отдел кадров��$	��650��$
��1200�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � 	Resources    TopMenuButtons �� 
TargetType � RowDefinitions �� 
TargetType �� Property �� Value	 �� Triggers
 �� Binding �� Path �� ElementName �� Value �� RelativeSource �� Mode �� AncestorType��%M  &	        �� " ��.R�� $	��Btn��$��60��$	��200��$��Center=�$
��Left=�.+��� $��0,0,21,0q�._�� $��	0,0,-21,0q� �� $��* �.+��� #��z��$��Bahnschrift Condensed)�$��Center=�$
��Left=�$��0,0,0,5q����� " ��.���  � �� �	#FFD3D7DA	 �� 
 �� $ IsMouseOver�$	 Btn�� True.a���  � ��
 ������� $��MouseOverBorder�����	#FF00FF33���� " ��.���  �@J�Opacity$ 0Q�	 �� 
 �� $ IsMouseOver�$	 Btn�� True.a���  �@J�Opacity$	 0.1Q��� $��IsSelectedBorder�����	#FF5AF77A���� " ��.���  �@J�Opacity$ 0Q���  � ��$ 3,0,0,0q���  � y�$ Hidden=���  � �� �	#FF588DF7	 �� 
 ��  �� $ FindAncestor=�" ��$ 	IsFocused� True.a���  � y�$ Visible=���  �@J�Opacity$	 0.5Q�.��� .+�� $��1�����	#FF312E2E �� $	��105 ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � � ColumnDefinitions �� $	��195 ��� $
��1005 �.+�� $��0��$��8�����	#FF1A1A1A$��
0,0,1000,0q�$��2���� $��Resources/Лого.png��$��31,0,0,0q�$��Center=�$
��Left=� � -   $��	MainFrame��$��8��  � NavigationUIVisibility$ Hidden=�$��5,0,0,0q�$��1���� -   $��Sotrud��$��1��#��[  $��Сотрудники�����	#FF1EC821
�������$��25(�$��Bahnschrift)�$��0,0,1000,75q�$��2��$��2���� -   $
��Dolg��$��2��#��[  $��Должность�����	#FF1EC821
�������$��25(�$��Bahnschrift)�$��
0,0,1000,0q�$��2���� -   $��Bolnich��$��2��#��[  $��Больничный�����	#FF1EC821
�������$��25(�$��Bahnschrift)�$��0,75,1000,75q�$��3��$��2���� -   $��	Uvolnenie��$��4��#��[  $��Уволнение�����	#FF1EC821
�������$��25(�$��Bahnschrift)�$��
0,0,1000,0q�$��2���� -   $��Komandir��$��4��#��[  $��Командировка�����	#FF14CA17
�������$��25(�$��Bahnschrift)�$��0,75,1000,75q�$��3��$��2���� -   $��Kondidat��$��6��#��[  $��Кандидаты�����	#FF1EC821
�������$��25(�$��Bahnschrift)�$��
0,0,1000,0q�$��2��