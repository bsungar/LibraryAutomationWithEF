   M S B A M L   `   `   `  ����J  FLibraryAutomata, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LibraryAutomata.ViewLibraryAutomata.View  5      E'clr-namespace:LibraryAutomata.viewmodelLibraryAutomata.viewmodel  5      !    LibraryAutomata.View.SignIn   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:LibraryAutomata.View     5      =	viewmodel'clr-namespace:LibraryAutomata.viewmodel     5      .��5      � 
����p��  � ColumnDefinitions  5   
   �� 5      $��8* �6   6,   �� 5      $��8* �6   6,   �� 5      $��8* �6   6,   �� 5      $��8* �6   6,   �� 5      $��8* �6   6,   �� 5      $��8* �6   6,    � RowDefinitions 5   
   �� 5      $��4* �6   6*   �� 5      $��4* �6   6*   �� 5      $��4* �6   6*   �� 5      $��4* �6   6*   �� 5      $��4* �6   6*   �� 5      $��4* �6   6*   �� 5      $��4* �6   6*   .+�5   
   �� -   5         ��Name$	 txt��5      $��0��6!   $��2��6.   $��Center=�6>   $��22(�6[   
�������$��Center=�6�   $��2��6�   $��SIGN IN��6�   6�   �� 5    
   -   5        $
 mail��5       $��1��6"   $��1��6/   $��E-Mail:��6?   $��Center=�6N   $��Center=�6i   $��16(�6�   
�������6�   �� 5!   
   -   5        $
 name��5!      $��2��6"   $��1��6/   $��Name:��6?   $��Center=�6L   $��Center=�6g   $��16(�6�   
�������6�   �� 5"   
   -   5        $ sname��5"      $��3��6#   $��1��60   $��Surname:��6@   $��Center=�6P   $��Center=�6k   $��16(�6�   
�������6�   �� 5#   
   -   5        $ 	passenter��5#      $��4��6'   $��1��64   $��	Password:��6D   $��Center=�6U   $��Center=�6p   $��16(�6�   
�������6�   �� 5$   
   -   5        $
 pass��5$      $��5��6"   $��1��6/   $��Password Again:��6?   $��Center=�6V   $��Center=�6q   $��16(�6�   
�������6�   �� 5%   
   -   5         ��Name$ 	mailenter��5%      $��1��6%   $��2��62   $��1��6B   $��Center=�6V   $��Center=�6q   6�   �� 5&   
   -   5        $ passsecenter��5&      $��5��6(   $��2��65   $��1��6E   $��Center=�6Y   $��Center=�6t   6�   �� 5'   
   -	   5        $ 	nameenter��5'      $��2��6%   $��2��62   $��1��6B   $��Center=�6V   $��Center=�6q   6�   �� 5(   
   -
   5        $ 
snameenter��5(      $��3��6&   $��2��63   $��1��6C   $��Center=�6W   $��Center=�6r   6�   �� 5)   
   -   5        $ 
passeneter��5)      $��4��6&   $��2��63   $��1��6C   $��Center=�6W   $��Center=�6r   6�   �� 5*   
   -   5         ��Name$ 
Signbutton��5*      $��Sign Up��6M   $��60��6_   $��40��6j   $��6��6v   $��3��6�   $
��Left=�6�   $	��Top=�6�   ��6%   ��  �� Path$ SigninCommand�6�   5+      5,      