   M S B A M L   `   `   `  ����V  RGoldenRhinoGameDistribution, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:GoldenRhinoGameDistributionGoldenRhinoGameDistribution  5   	   )    #GoldenRhinoGameDistribution.AddGame   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:GoldenRhinoGameDistribution     5   	     � Title$  AddGame��5   	   ���	#FF4E0002$	��800��60   $	��300��6=    � WindowStartupLocation$ CenterScreen=�6I   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� ���	#FFFFC926$��Add Your Game Here��6'   $��Center=�6D   �� 5   
   $��1��6   $��Title:��6   ���	#FFFFC9266G   �� 5   
   -   5         ��Name$ tbTitle��5   +   $��1��6   $��20��6   ���	#FFFFC926$��Center=�6S   ���	#FF8F0000���	#FFFFC9266�   �� 5   
   $��2��6   $��Title Type:��6   ���	#FFFFC9266L   �� 5   
   -   5        $ tbTitleType��5      $��2��6   $��20��64   ���	#FFFFC926$��Center=�6W   ���	#FF8F0000���	#FFFFC9266�   �� 5   
   $��3��6   $��Company:��6   ���	#FFFFC9266I   �� 5   
   -   5        $ 	tbCompany��5      $��3��6%   $��20��62   $��Center=�6>   ���	#FFFFC926���	#FF8F0000���	#FFFFC9266�   �� 5    
   $��4��6   $��Developers:��6   ���	#FFFFC9266L   �� 5!   
   -   5        $ tbDevelopers��5!      $��4��6   $��20��65   ���	#FFFFC926$��Center=�6X   ���	#FF8F0000���	#FFFFC9266�   �� 5#   
   -   5         ��Name$ ImagePickerButton��5#      $��5��6   $��image��69   ���	#FFFFC926���	#FF8F0000���	#FFFFC9266�   �� 5%   
   $��6��6   $��Genre:��6   ���	#FFFFC9266G   �� 5&   
   -   5        $ tbGenre��5&   +   $��6��6   $��20��6   ���	#FFFFC926$��Center=�6S   ���	#FF8F0000���	#FFFFC9266�   �� 5'   
   $��7��6   $��Cost to Company:��6   ���	#FFFFC9266Q   �� 5(   
   -   5        $ tbCompanyCost��5(   +   $��7��6   $��20��6   ���	#FFFFC926$��Center=�6Y   ���	#FF8F0000���	#FFFFC9266�   �� 5)   
   $��8��6   $��Price��6   ���	#FFFFC9266F   �� 5*   
   -   5        $ tbPrice��5*   +   $��8��6   $��20��6   ���	#FFFFC926$��Center=�6S   ���	#FF8F0000���	#FFFFC9266�   �� 5+   
   $��9��6   $��Quantity��6   ���	#FFFFC9266I   �� 5,   
   -	   5        $ 
tbQuantity��5,   +   $��9��6   $��20��6   ���	#FFFFC926$��Center=�6V   ���	#FF8F0000���	#FFFFC9266�   �� 5-   
   $��10��6   $��Release Date��6   ���	#FFFFC9266N   (  "System.Windows.Controls.DatePicker  5.   
   -
   5          Name$ 	tbRelease��5.   :   $��10��6   ���	#FFFFC926$��29��6M   $��Center=�6Y   ���	#FF8F0000���	#FFFFC926$��	0,20,0,10q�6�   �� 5/   
   $��11��6   $��Delevery Type��6   ���	#FFFFC9266O   �� 50   
   -   5        $ tbDeliveryType��50   ,   $��11��6   $��20��6    ���	#FFFFC926$��Center=�6[   ���	#FF8F0000���	#FFFFC9266�   �� 51   
   -   5        $��12��51      $��submit��6   ���	#FFFFC926���	#FF8F0000���	#FFFFC9266v   52      53      