   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.AddBolnich   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:WpfApp1       N� Title$  
AddBolnich��.��� ���	#FF1A1A1A � RowDefinitions �� $��30 ��� $��40 ��� $��30 ��� $��40 ��� $��30 ��� $��40 ��� $��30 ��� $��40 ��� $��30 ��� $��40 ��� $��* �.+��� $,��&Добавить Сотрудника:��$��15(�$��Bottom=�$
��10 0q�$��0��
�������$��Bahnschrift)��� -   $��CBdolg��$��15(�$��1��$��30��$��Center=�$	��780�� �� DisplayMemberPath$	 FIO��$��Bahnschrift)� �� SelectedItem �� *Sotrud+�� $-��'Добавить Дату начала:��$��15(�$��Bottom=�$
��10 0q�$��2��
�������$��Bahnschrift)�(  "System.Windows.Controls.DatePicker  $��15(�$��3��$��30��$��Center=�$	��780��$��Bahnschrift)�   SelectedDate �� *	DataStart+�� $3��-Добавить Дату окончания:��$��15(�$��Bottom=�$
��10 0q�$��4��
�������$��Bahnschrift)�  $��15(�$��5��$��30��$��Center=�$	��780��$��Bahnschrift)� �� *	DataEnd+�� -    ��Name$ 	textBlock��$$��Добавить оплату:��$��15(�$��Bottom=�$
��10 0q�$��6��
�������$��Bahnschrift)��� $��15(�$��7��$��30��$��Center=�$	��780��$��Bahnschrift)����� *Oplata+�� $&�� Добавить причину:��$��15(�$��Bottom=�$
��10 0q�$��8��
�������$��Bahnschrift)��� $��15(�$��9��$��30��$��Center=�$	��780��$��Bahnschrift)����� *Prich+�� -   $��Сохранить��$��10��$��30��$	��150��$��17(����	#FF14CA17
�������$��	0,0,150,0q�$��Bahnschrift)��� -   $��
Назад��$��10��$��30��$	��150��$��17(����	#FF14CA17
�������$��415,35,235,35q�$��Bahnschrift)�