   M S B A M L   `   `   `  ����?  ;Kviz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KvizKviz  5   	       
Kviz.Login   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Kviz     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Prijava��5	   	    � 
ResizeMode$ NoResize=�6   $	��400��6/   $	��300��6;   .��5
      �  � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $
��0.2* �6    � ColumnDefinitions 5   
   �� 5      $
��0.7* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   .+�5   
   ]� $��0��6   $��0��6!   $��2��61   ���	#FF0026276B   �� 5   
   $
��Wrap=�6   $��0��6(   $��0��65   $��2��6E   $��Dobrodošli u kviz��6V   
�������$��30(�6�    �� TextAlignment$ Center=�5      $��2��6+   $��-1,83,117,0q�6?   �� 5   
   -   5        $��1��5      $��1��6!   $��2��6.   $	��150��6B   $��40��6N   $��Započni igru��6Z   $��20(�5      ���	#FFFFFF41   RoundButton#��[  66   $��4q�6[   ���	#FF9E09096o   �� 5   
   -   5         ��Name$ userImg��5      $��0��6!   $��1��6.   $��83��6>   $	��Top=�6J   $	��100��6b   $��	67,8,68,0q�6n   $��2��6�   �� 5   
   $��1��6   $��Unesite ime:��6    $
��Left=�67   $��
59,101,0,0q�6R   $	��Top=�6f   $	��100��6~   $��2��6�   $��16(�6�   �� 5   
   -   5         ��Name$ userName��5      $��1��6$   $��2��64   $
��Left=�6H   $��
40,140,0,0q�6c    �� TextWrapping$ NoWrap=�6w   $	��Top=�6�   $	��150��6�   ���	#FF002627
�������$��20(�6�   	 �� TextAlignment$	 Center=�6�   5!      5"      