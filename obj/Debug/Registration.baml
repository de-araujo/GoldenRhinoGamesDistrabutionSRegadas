   M S B A M L   `   `   `  ����V  RGoldenRhinoGameDistribution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:GoldenRhinoGameDistributionGoldenRhinoGameDistribution  5   	   .    (GoldenRhinoGameDistribution.Registration   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:GoldenRhinoGameDistribution     5   	     � Title$  Registration��5   	   $	��500��6   $	��400��6+    � WindowStartupLocation$ CenterScreen=�67    +� FocusedElement 6\   ��  �� ElementName$ 
tbUsername��.��5
      � $��1��6   ���	#FF454545 � ColumnDefinitions 5      �� 5      $��* �6#    � RowDefinitions 5      �� 5      $��* �6    �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    �� 5      $��* �6    .+�5      �� $��0��6   $^��Xhttps://avatar-management--avatars.us-west-2.prod.public.atl-paas.net/default-avatar.png��6!   �� 5      $��1��6   $��30��6!   $��15(�6-   $��
comic sans)�6;   $��0,5,0,43q�6S   
�������$��Username��6x   �� 5   
   -   5         ��Name$ 
tbUsername��5      $��40��6&   $��30(�62   $��1��6@   $��	0,26,0,12q�6M   
����������	#FF6A6A6A���#4545456�   �� 5      $��2��6   $��30��6!   $��15(�6-   $��0,3,0,45q�6;   
�������$��Email��6`   �� 5   
   -   5        $ tbEmail��5      $��40��6#   $��2��6/   $��30(�6<   $��	0,26,0,12q�6J   
����������	#FF6A6A6A���#4545456�   �� 5      $��3��6   $��30��6!   $��15(�6-   $��0,3,0,45q�6;   
�������$��Password��6`   G� 5   
   -   5         G�Name$ 
tbPassword��5      $��40��6*   $��3��66   $��30(�6C   $��	0,25,0,13q�6Q   ���	#FF6A6A6A���#454545
�������6�   �� 5   
   $��4��6   $��30��6   $��15(�6)   $��0,3,0,45q�67   
�������$��Verify Password��6\   G� 5   
   -   5        $ tbVerifyPassword��5      $��40��60   $��4��6<   $��30(�6I   $��	0,25,0,13q�6W   ���	#FF6A6A6A���#454545
�������6�   ]� 5    
   $��30��6   .+�5!      �� -   5         ��Name$ btnRegister��5!   '   $��70,0,0,0q�6   $��40��6<   $	��100��6H   $��Register��6U   ���	#FF0CFF006   �� 5"      -   5        $ btnLogin��5"      $��40��6'   $	��100��63   $��login��6?   ���	#FF0CFF006f   5#      5%      5&      