   M S B A M L   `   `   `  ����C  ?PRACTIC1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PRACTIC1PRACTIC1  5          PRACTIC1.ProjectPage   5      _ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:PRACTIC1     5        N� Title$  ProjectPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   .+�5   
   �� -   5         ��Name$
 Name��5       �� 
IsEditable . )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Назание��64      HintOpacity$	 .26Q�6]    �� Text$  ��6�   $��1��6�   �� 5   
   -   5        $ Description��5       . $ Описание��6:   $	 .26Q�6d   $  ��6�   $��2��6�   �� 5   
   -   5         ��Name$	 Add��5      $��3��6   $��Добавление��6+    %  !MaterialDesignOutlinedLightButton#��[  6@    � ToolTip$" MaterialDesignOutlinedButton��6{   $��Center=�6�   6�   �� 5   
   -   5        $ Delete��5      $��4��6!   $��Удаление��6.   #��[  6A   $" MaterialDesignOutlinedButton��6|   $��Center=�6�   6�   �� 5   
   -   5        $ Update��5      $��5��6!   $��Обновление��6.   #��[  6C   $" MaterialDesignOutlinedButton��6~   $��Center=�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 ProjectTable��5   /   
   AutoGenerateColumns
 .  $��0��6E      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%      
Visibility$ 	Collapsed=�64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� *
ID_Project+  5      $ Название��6%    67   �� *Title+  5      $ Описание��6%    67   �� *Dedcription+5       5!      5"      