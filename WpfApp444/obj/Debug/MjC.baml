   M S B A M L   `   `   `  ����D  @WpfApp444, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WpfApp444	WpfApp444  5   	       WpfApp444.MjC   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WpfApp444     5   	     � Title$	  MjC��5   	   $	��450��6   $	��800��6"   .��5	      � $��0,0,2,0q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridMjC��5
      $��5��6(      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ��  �� Path$ NameTC�6c     5      $ Статус��6%   $ * 65    6?   �� $ Status�6a     5      $! Кол.Повильонов��6%   $ * 6=    6G   �� $ CountPow�6k     5      $ 
Город��6%   $ * 64    6>   �� $ CityName�6b     5      $ Стоимость��6%   $ * 68    6B   �� $
 Stoi�6b     5      $7 1Коэф. Добавочной стоимости��6%   $ * 6I    6S   �� $
 Coof�6s     5      $ Этажность��6%   $ * 68    6B   �� $ Floors�6d   5      �� 5   
   -   5         ��Name$ EdditA��5   F   $��1��6   $��4��6!   $ ��Редактировать��6.   $��14(�6V   $��Arial)�6d   ���#ff9c1a
�������6�   �� 5   
   -   5        $
 AddA��5   A   $��1��6   $��3��6!   $��Добавить��6.   $��14(�6O   $��Arial)�6]   ���#ff9c1a
�������6�   �� 5   
   -   5        $ DeleteA��5   @   $��1��6   $��1��6!   $��Удалить��6.   $��14(�6Q   $��Arial)�6_   ���#ff9c1a
�������$��0,0,0,54q�6�   �� 5   
   -   5         ��Name$ textBoxDeleteMjC��5   "   $��1��6   $��
21,52,19,5q�6<   6R   �� 5   
   -   5        	 ��Name$	 labelDeleteMjC��5       $��1��6   $X��RВведите название тц, 
которое хотите удалить��68   $��0,0,0,28q�6x   $��12(�6�   6�   
 � ColumnDefinitions
 5   
   �� 5      $	��637 �6   6-   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5       6   �� 5!      6   �� 5"      6   �� 5#      6   5%      5&      