   M S B A M L   `   `   `  ����C  ?PRACTIC1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PRACTIC1PRACTIC1  5      #    PRACTIC1.SearchProjectsDTPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:PRACTIC1     5      _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
        N� Title$  SearchProjectsDTPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� -   5         ��Name$ 
SearchText��5   &   $��0��6   6<   �� 5      -   5         ��Name$ Search��5   %   $��1��6   $��
Поиск��65    %  !MaterialDesignOutlinedLightButton#��[  6E    � ToolTip$" MaterialDesignOutlinedButton��6�   6�   5      � 5   
   $��1��6    5      �� 5      �� 5      .+�5      �� -   5         ��Name$ 
ComboFiltr��5   '   $��0��6    �� 
IsEditable . )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Название��6N   6�   �� 5       -   5        $ 
ClearFiltr��5    %   $��1��6   $��Очистить��69   #��[  6L   $" MaterialDesignOutlinedButton��6�   6�   5!      &   System.Windows.Controls.DataGrid  5"   
   -   5        	  Name$	 DopTable��5"   /   
   AutoGenerateColumns
 .  $��2��6A      Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%      
Visibility$ 	Collapsed=�64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� *
ID_Ptoject+  5%      $ Название��6%    67   �� *Title+  5&      $ Описание��6%    67   �� *Dedcription+5(      5)      5*      