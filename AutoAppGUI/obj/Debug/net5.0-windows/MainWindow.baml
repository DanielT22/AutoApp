   M S B A M L   `   `   `  ����  
AutoAppGUI    AutoAppGUI.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  AutoApp��5   	   $	��650��6   $	��820��6&   $	��650��5   	   $	��820��5   	   .��5	      � $��0,0,0,0q�6   .+�5
   
   �� $��Results��6   $
��Left=�6"   $��
18,458,0,0q�6=   $	��Top=�6Q   $��25��6i   $��68��6u   �� 5   
   -   5        $��Application1��5   (   $��10,48,161,0q�6   $	��391��6T   $	��Top=�6a   ��6<   ��  �� View 5      �� 5      .P�5      �� $��App Name��6%    �� Width$
 Auto��67    �� DisplayMemberBinding 6D   �� *	AppName+�� 5      $��	Directory��6%   $	 280��68    6D   �� *	Directory+�� 5      $��Local Version��6%   $
 Auto��6<    6I   �� *LocalVersion+�� 5      $��Latest Version��6%   $
 Auto��6=    6J   �� *LatestVersion+�� 5      $��Selected��6%   $
 Auto��67   -   5        CheckBoxColumn�� �� CellTemplate 5      �� 5      .R�5   "   � ��6'   ��  �� ElementName$ CheckBoxColumn�� �� Path$ Width�.+�5   &   �� $��Center=�6/    d� 	IsChecked 6L   �� *
IsSelected+5   #   5      5      5      .@�5      �� $	��100��6   $	��100��6#   5      �� 5   
   -   5         ��Name$ DirectoryValue��5   ?   $��10,10,161,0q�6   $	��Top=�6'   6Y   �� 5    
   -   5        $��Select App Directory��5       $
��Left=�60   $��
661,10,0,0q�6K   $	��Top=�6_   $	��129��6w   6�   �� 5!   
   $��Disabled=�6   $
��Auto=�6>   $��	0,488,0,0q�6c   .��5"      �� $
��Left=�65   $	��120��6P   $��
18,488,0,0q�6]   $
��Wrap=�6q   $	��Top=�6�   $	��761��6�   ��6   �� *ResultsText+6�   5#      �� 5$   
   -   5        $��Add Application��5$      $
��Left=�6+   $��661,297,0,0q�6F   $	��Top=�6[   $	��129��6s   6   �� 5%   
   -   5        $��Remove Application��5%      $
��Left=�6.   $��661,330,0,0q�6I   $	��Top=�6^   $	��129��6v   6�   �� 5&   
   $��
Update All��6   $��25(�6&   $
��Left=�64   $��
661,48,0,0q�6O   $	��Top=�6c   $��44��6{   $	��129��6�   �� 5'   
   $��Check for Updates��6   $
��Left=�6-   $��661,111,0,0q�6H   $	��Top=�6]   $	��129��6u   �� 5(   
   $��Update Selected��6   $
��Left=�6+   $��661,146,0,0q�6F   $	��Top=�6[   $	��129��6s   $��21��6   �� 5)   
   $��	Check All��6   $
��Left=�6%   $��664,198,0,0q�6@   $	��Top=�6U   $��24��6m   $	��126��6y   �� 5*   
   $��Uncheck All��6   $
��Left=�6'   $��664,232,0,0q�6B   $	��Top=�6W   $��24��6o   $	��126��6{   5+      5,      