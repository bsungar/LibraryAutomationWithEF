   M S B A M L   `   `   `  ����J  FLibraryAutomata, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LibraryAutomata.ViewLibraryAutomata.View  5      G(clr-namespace:LibraryAutomata.NavigationLibraryAutomata.Navigation  6?   G(clr-namespace:LibraryAutomata.NavigationLibraryAutomata.Navigation  6{   E'clr-namespace:LibraryAutomata.viewmodelLibraryAutomata.viewmodel  6�   +    %LibraryAutomata.View.LoginUserControl   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:LibraryAutomata.View     5      ?
navigation(clr-namespace:LibraryAutomata.Navigation     6?   >	viewmodel(clr-namespace:LibraryAutomata.Navigation     6{   >
viewmodel1'clr-namespace:LibraryAutomata.viewmodel     6�   .��5	      � 
������  � ColumnDefinitions  5
   
   �� 5      $��8* �6   6,   �� 5      $��8* �6   6,   �� 5      $��8* �6   6,   �� 5      $��8* �6   6,   �� 5      $��8* �6   6,   �� 5      $��8* �6   6,    � RowDefinitions 5   
   �� 5      $��4* �6   6*   �� 5      $��4* �6   6*   �� 5      $��4* �6   6*   �� 5      $��4* �6   6*   �� 5      $��4* �6   6*   .+�5   
   �� -   5         ��Name$	 txt��5      $��0��6!   $��2��6.   $��Center=�6>   $��22(�6[   
����p��$��Center=�6�   $��2��6�   $��LOGIN��6�   6�   �� 5   
   -   5        $
 mail��5      $��1��6"   $��1��6/   $��E-Mail:��6?   $��Center=�6N   $��Center=�6i   $��16(�6�   
����p��6�   �� 5   
   -   5        $
 pass��5      $��2��6"   $��1��6/   $��	Password:��6?   $��Center=�6P   $��Center=�6k   $��16(�6�   
����p��6�   �� 5   
   -   5         ��Name$ 	mailenter��5      $��1��6=   $��2��6J   $��1��6Z   $��Center=�6n   $��Center=�6�   ��6%   �� *Email+6�   �� 5   
   -   5        $ 	passenter��5      $��2��6@   $��2��6M   $��1��6]   $��Center=�6q   $��Center=�6�   ��6%   �� *
Password+6�   �� 5   
   -   5         ��Name$ tosign��5      $��Center=�6H   $��Center=�6l   $�� Go Sign In��6�   $��3��6�   $��3��6�   $��11(�6�   $	��Top=�6�   $��40��6�   $��73,0,0,0q�6�   ��6!   ��  �� Path$ LoginCommand�6�   �� 5    
   -   5        $ loginbutton��5       $��Enter��6N   $��60��6^   $��40��6i   $��3��6u   $��3��6�   $
��Left=�6�   $	��Top=�6�   ��6&   �� $ LoginCommand�6�   5!      5"      