   M S B A M L   `   `   `  ����J  FLibraryAutomata, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LibraryAutomata.ViewLibraryAutomata.View  5      E'clr-namespace:LibraryAutomata.viewmodelLibraryAutomata.viewmodel  5      "    LibraryAutomata.View.Library   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:LibraryAutomata.View     5      =	viewmodel'clr-namespace:LibraryAutomata.viewmodel     5      $	��600��5	      $	��800��6,   .��5      �� .��5   
   � 
�������  � ColumnDefinitions  5      �� 5      $��4* �6#   �� 5      $��4* �6#   �� 5      $��4* �6#   �� 5      $��4* �6#   �� 5      $��4* �6#   �� 5      $��4* �6#    � RowDefinitions 5      �� 5      $��5* �6    �� 5      $��5* �6    �� 5      $��5* �6    �� 5      $��5* �6    �� 5      $��5* �6    �� 5      $��5* �6    �� 5      $��5* �6    .+�5      �� -   5         ��Name$	 lib��5      $��LIBRARY��6%   
���  ��$��2��6I   $��2��6Y   $��Center=�6m   $��Center=�6�   $��20(�6�   �� 5       -   5        $	 cat��5       $��	Category:��6%   
���  ��$��1��6K   $��1��6X   $��Center=�6h   $��Center=�6�   $��13(�6�   �� 5!      -   5        $ bname��5!      $��
Book Name:��6'   
���  ��$��2��6N   $��1��6[   $��Center=�6k   $��Center=�6�   $��13(�6�   �� 5"      -   5        $ authorn��5"      $��Author Name:��6)   
���  ��$��3��6R   $��1��6_   $��Center=�6o   $��Center=�6�   $��13(�6�   �� 5#      -   5        $ description��5#      $��Description:��6-   
���  ��$��4��6V   $��1��6c   $��Center=�6s   $��Center=�6�   $��13(�6�   �� 5%      -   5         ��Name$
 tcat��5%      
���  ��$��1��6S   $��2��6`   $��Center=�6p   $��13(�6�   ��6$   �� *
Category+6�   �� 5&      -   5        $ tbname��5&      
���  ��$��2��6R   $��2��6_   $��Center=�6o   $��13(�6�   ��6&   �� *Title+6�   �� 5'      -   5        $ tauthorn��5'      
���  ��$��3��6Y   $��2��6f   $��Center=�6v   $��13(�6�   ��6(   �� *
AuthorName+6�   �� 5(      -	   5        $ tdescription��5(      
���  ��$��4��6^   $��2��6k   $��Center=�6{   $��13(�6�   ��6,   �� *Description+6�   �� 5)      -
   5         ��Name$ Delete��5)      $��DELETE��6%   $
��Left=�6^   $��4��6y   $��5��6�   $��Center=�6�   $��60��6�   $��50��6�   ��66   ��  �� Path$ DeleteCommand�6�   �� 5*      -   5        $	 Add��5*      $	��ADD��6F   $��5��6T   $��2��6a   $
��Left=�6q   $��Center=�6�   $��13(�6�   $��60��6�   $��50��6�   ��6"   �� $ 
AddCommand�6�   �� 5+      -   5        $ Search��5+      $��SEARCH��6%   $��5��6]   $��3��6j   $
��Left=�6z   $��Center=�6�   $��13(�6�   $��60��6�   $��50��6�   ��66   �� $ SearchCommand�6�   �� 5,      $��6��6   $��3��6)   $	��400��6=   $��1��6I   $��5,8,5,8q�6Y   $	��150��6j   .��5-      &   System.Windows.Controls.DataGrid  -   5          Name$ datalibrary��5-         AutoGenerateColumns$ False��60   $	��300��6L   $	��450��6�   ��6Z   �� $ Books� �� SelectedItem 6}   �� *CurrentBook+	   Columns	 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      
   
Foreground

 �  ��,  &System.Windows.Controls.DataGridColumn   Header$ Title��6C      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6\   �� $ Title�  50      

 �  ��$ 
AuthorName��6B   $ * 6V    6`   �� $ 
AuthorName�  51      

 �  ��$ Category��6F   $ * 6X    6b   �� $ Genre�  52   "   

 �  ��$ Description��6J   $ * 6_    6i   �� $ Description�54      55      56      57      58      