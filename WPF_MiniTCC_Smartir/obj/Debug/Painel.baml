   M S B A M L   `   `   `  ����N  JWPF_MiniTCC_Smartir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPF_MiniTCC_SmartirWPF_MiniTCC_Smartir  5   	        WPF_MiniTCC_Smartir.Painel   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPF_MiniTCC_Smartir     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	     � Title$  SmartAir - Home��5	   	   $	��720��6!   $
��1280��6.    � WindowStartupLocation$ CenterScreen=�6;    � 
ResizeMode$ CanMinimize=�6`    � Icon$" /Imagens/Icone Smart Air.png��6y   .��5
      � ���	#FF0F1923.+�5   
   �� $��1q�6    �� CornerRadius$ 	0,50,50,0��6&   $
��Left=�6?   $	��720��6Z   $��Center=�6g   $	��333��6�   
�������$��-1,0,0,0q�6�   ._�5      �� $��Bottom=�6   $��Center=�64    �� Orientation$ 
Horizontal=�6Q   $��50q�6j   .+�5      "  FontAwesome.WPF.ImageAwesome  -   5          Name$ 
icnAddUser��5   "      Icon$ UserPlus=�66   $��30��6F   $��
10,0,10,10q�6Q    � Cursor$
 Hand��6�     5      -   5        $ 	icnAddLab��5   "   $ Desktop=�65   $��30��6D   $��
10,0,10,10q�6O   $
 Hand��6�     5      -   5        $ 	icnAddEsp��5   "   $
 Gear=�65   $��30��6A   $��
10,0,10,10q�6L   $
 Hand��6�   5      5      �� 5   
   -   5        	 ��Name$	 LaboratoriosList��5      $��0q�6,   $��39,70,948,110q�6@   $
 Hand��6W   ��6e   Z� ��5      �� 5      .R�5      �� $ Vertical=�6!   $��10q�68   .+�5      �� $ 
Horizontal=�6%   $  ��6>   .+�5      �� $��FontAwesome)�6(   $��14(�6A   $��0,0,5,0q�6O   $��Center=�6`     5      $ icnPC��6+   $ Laptop=�6:   $��30��6H   $��0,0,0,3q�6S   $
 Hand��6d   5       �� 5#      $
��Bold"�6>   $��14(�6P   ��6(   �� *Nome+6P   5$      �� 5'      $��10(�6$   ���	#FF868686�� 5(      $�
Esp32 ID: ��6    �� 5)      �6   �� *
Esps[0].Id+5*      �� 5-      $��12(�6$   ��5.      �� 5/   "   
 �� 
TargetType"
 ��6(   .�50   &   ��  �� Property � �� �� Value
 �   �6C    �� Triggers 51   &   �� 52   *    �� Binding 66   �� *Esps[0].Estado+ �� Value
 online6Y   .a�53   .   ��  � ��
 � � �6K   54   +   �� 55   *    66   �� *Esps[0].Estado+ offline6Y   .a�56   .   ��  � ��
 �  ��6K   57   +   59   #   �� 5;      �6   �� *Esps[0].Estado+5<      5=      5>      5@      � 5C   
   -   5         �Name$ grdMenuControl��5C      $y�	Collapsed=�6'   .+�5D      �� -   5         ��Name$ 	lblTitulo��5D      $	��Lab��6'   $
��Left=�65   $��
470,94,0,0q�6P   $	��Top=�6d   
�������$��36(�6�   $
��Bold"�6�   �� 5E      -   5        $ lblIdEsp��5E      $	��001��6&   $
��Left=�64   $��473,134,0,0q�6O   $	��Top=�6d   
�������6|   �� 5F      -   5        $ lblStatusEsp��5F      $
��Left=�5G      $��473,148,0,0q�6+   $	��Top=�5H      $��10(�6(   ��5F   *   �� *Esps[0].Estado+��5I      �� 5J      "
 ��6   .�5L      ��  � ��
 �  ��67    5P      �� 5R       6*   �� *	Content+ �� RelativeSource �� *Self+
 online6l   .a�5S   "   ��  � ��
 � � �6?   5T      �� 5W       6*   �� *	Content+ �� *Self+ offline6l   .a�5X   "   ��  � ��
 �  ��6?   5Y      5[      5]      �� 5`      -	   5        $ 
lblTempLab��5`      $��36°C��6(   $
��Left=�67   $��470,156,0,0q�6R   $	��Top=�6g   
�������$��32(�6�   $
��Bold"�6�   5a      5d      5f      