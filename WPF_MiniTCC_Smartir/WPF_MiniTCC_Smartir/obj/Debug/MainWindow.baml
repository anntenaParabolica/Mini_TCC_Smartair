   M S B A M L   `   `   `  ����N  JWPF_MiniTCC_Smartir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPF_MiniTCC_SmartirWPF_MiniTCC_Smartir  5   	   $    WPF_MiniTCC_Smartir.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPF_MiniTCC_Smartir     5   	     � Title$  SmartAir - Login��5      $	��720��6   $
��1280��6,    � WindowStartupLocation$ CenterScreen=�69    � 
ResizeMode$ CanMinimize=�6^    � Icon$" /Imagens/Icone Smart Air.png��6w    � 	Resources 5
         EstiloBtnLogar �� 
TargetType �� Property �� Value �� 
StartPoint	 �� EndPoint
 � Color � Offset �� 
TargetType �� CornerRadius �� Padding��%�  &	        �� 5   
   " ��6'   .�5      ��  � �� 5      �� 5      $ 0,0.5&�6*   $	 1,0.5&�6=   .��5      � $
 	#FF1AA1F1��6'   $ 0Q�69   � 5      $
 	#FF57C8F6��6'   $ 1Q�69   5      5      �� 5       � ��
 �����6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $��5q�5      $ 12��5      $ 5q�5   !   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5!      5"      .��5%      � 
���   �.+�5&   
   �� $��Center=�6   $	��720��6-   $	��Top=�6:   $&�� /Imagens/BackgroundGradiente.png��6R   $
��1280��6|   $��0,0,0,0q�6�   �� 5)   
   ���#f5f5f5$ 20��6&   $��2q�68   $��381,174,381,174q�6L   ._�5+      �� $��LOGIN��6   $��Center=�6$   $	��Top=�6A   $��16(�6Y   $��	0,123,0,0q�6g   ���	#FF0F19236z   5,      �� 50   
   -   5         ��Name$	 img��50      $��Center=�6   $��45��6:   $	��Top=�6F   $	��188��6^   $&�� /Imagens/SmartAir DarkSIMPLE.png��51   
   $��	0,242,0,0q�64    �� BitmapScalingMode$ HighQuality=�6G   �� 52   
   $��ID��6   $
��Left=�6   $��40��68   $��535,314,0,0q�6D   $	��Top=�6Y   $	��115��6q   
�������6}   �� 53   
   $��SENHA��6   $
��Left=�6    $��40��6;   $��535,374,0,0q�6G   $	��Top=�6\   $	��115��6t   
�������6�   �� 56   
   -   5         ��Name$ txtID��56      $��Center=�6"   $��0,332,0,331q�6?   $	��210��6T   $��0, -5, 0, -15q�6a   $��16(�6z   ���#0F1923$��
0, 0, 0, 3q�6�    J� RenderTransformOrigin$ 	0.6,1.413&�6�    �� 	MaxLength$ 3��6,  .��6:  ��57      �� 58       �� ImageSource$ /Imagens/user2.png��6    j� Stretch$ Uniform=�6>    j� 
AlignmentX$
 Left=�6P   $ HighQuality=�6b   .��59   "   5:      G� 5;   
   -   5         G�Name$ pswSenha��5;      $��Center=�6)   $��0,393,0,270q�6F   $	��210��6[   $��0, -5, 0, -10q�6g   $��16(�6�   ���#0F1923$��
0, 0, 0, 3q�6�   $ 	0.6,1.413&�6�    G� 	MaxLength$ 20��6  ��5<      �� 5=      $ /Imagens/key.png��6   $ Uniform=�6<   $
 Left=�6N   $ HighQuality=�6`   5?      �� 5B   
   -   5         ��Name$ btnLogar��5B      $��Logar��6#   $��Center=�63   $	��Top=�6P   #��[  6h   $	��100��6�   $��52��6�   $��	0,433,0,0q�6�   $
��Bold"�6�    � Cursor$
 Hand��6�   �� 5C   
   -   5        $	��-->��5C      $
��Left=�6   $��1146,621,0,0q�6:   $	��Top=�6P   $��20(�6   $ 0.868,4.823&�6�   5E      5F      