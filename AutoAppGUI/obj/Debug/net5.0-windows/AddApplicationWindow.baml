   M S B A M L   `   `   `  ����E  AAutoAppGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AutoAppGUI
AutoAppGUI  5   	   %    AutoAppGUI.AddApplicationWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AutoAppGUI     5   	     � Title$  Add Application��5   	   $	��120��5	   	   $	��800��5
   	    � SizeToContent$ WidthAndHeight=�5   	    � 
ResizeMode$ NoResize=�5   	    � ShowInTaskbar$ False��5   	    � WindowStartupLocation$ CenterOwner=�5   	   $	��193��5   O   $��80��6[    +� FocusedElement 6	   ��  �� ElementName$ leftMarginTextBox��.��5      � $��10q�6    � 	Resources 5   
    �� 
TargetType	 �� Property
 �� Value��%v  '��       '�� v     '�� �     �� 5      " ��6   .�5      �� 	 � ��$
 0,3,5,5q�6+   �� 5      	 � ��$
 0,0,0,5q�6,   5      �� 5      " ��6   .�5      �� 	 � ��$
 0,0,0,5q�6+   5      �� 5      " ��6   .�5      �� 	 � ��$
 70��6*   �� 5      	 � ��$
 25��6+   �� 5      	 � ��$
 5,0,0,0q�6+   5      5       � ColumnDefinitions 5!   
   �� 5"      $
��Auto �6   �� 5#       � RowDefinitions 5&   
   �� 5'      $
��Auto �6   �� 5(      $
��Auto �6   �� 5)      $
��Auto �6   �� 5*      $
��Auto �6   �� 5+      $
��Auto �6   �� 5,      .+�5/   
   �� $��0��6   $��0��6    .��6-   
Tool Name:69   �� 50   
   -   5        $��leftMarginTextBox��50      $��1��6+   $��0��6;   �� 52   
   $��0��6   $��1��6    .��6-   
Directory:69   �� 53   
   -   5         ��Name$ DirectoryValue��53      $��1��6*   $��1��6:   �� 56   
   $��0��6   $��2��6%   $��4��69    �� Orientation$ 
Horizontal=�6F   $��Right=�6_   .+�57      �� -   5         ��Name$ ChooseDirectory��57       �� 	IsDefault$
 True��6O   $��Choose Directory��6`   $
��Auto��6{   �� 58      -   5        $ okButton��58      $
 True��6L   $��OK��6]   �� 59      -   5        $ cancelButton��59       �� IsCancel$
 True��6+   $��Cancel��6;   5:      5;      5<      