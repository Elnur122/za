   M S B A M L   `   `   `  ����D  @WpfApp444, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WpfApp444	WpfApp444  5   	       WpfApp444.Admin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WpfApp444     5   	     � Title$  Admin��5   	   $	��432��6   $��815.5��6$   .��5	      � $��0,0,2,0q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataGrid1��5
   S   $��	0,0,143,0q�6      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 66   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   ��  �� Path$ surname�6c     5      $ Имя��6%   $ * 62    6<   �� $
 name�6\     5      $ Отчество��6%   $ * 67    6A   �� $ middle_name�6h     5      $ 
Логин��6%   $ * 64    6>   �� $ login�6_     5      $ Пароль��6%   $ * 65    6?   �� $ password�6c     5      $ Роль��6%   $ * 63    6=   �� $
 role�6]     5      $! Номер телефона��6%   $ * 6=    6G   �� $ number_of_phone�6r   5      �� 5   
   $��
Emblem.png��6   $��754,385,10,10q�6$   6=   �� 5   
   -   5         ��Name$ DeleteA��5   9   $��663,55,0,296q�6   $��Удалить��6'   $��14(�6J   $��Arial)�6X   ���#ff9c1a
�������6�   �� 5   
   -   5        $ EdditA��5   >   $��663,0,0,346q�6   $ ��Редактировать��6&   $��14(�6N   $��Arial)�6\   ���#ff9c1a
�������6�   �� 5   
   -   5        $
 AddA��5   ;   $��663,105,0,246q�6   $��Добавить��6(   $��14(�6I   $��Arial)�6W   ���#ff9c1a
�������6�   5      5      