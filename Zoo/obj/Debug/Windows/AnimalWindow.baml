   M S B A M L   `   `   `  ����>  :Zoo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Zoo.WindowsZoo.Windows  5   	       Zoo.Windows.AnimalWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Zoo.Windows     5   	     � Title$  AnimalWindow��5   	   $	��850��6   $
��1200��6+    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	    � Icon$ /Assets/Logo.png��6    � AllowsTransparency . ��5   	   Z� .��5      �� ���#373737 �� CornerRadius$ 15��5      ._�5   
   �  � RowDefinitions 5      �� 5      $��25 �6    �� 5      $	��100 �6    �� 5      $	��575 �6    �� 5      $��* �6    .+�5      � -   5         �Name$ ToolBar��5      
������ .+�5      �� $��/Assets/Logo.png��6   $��25��62   $
��Left=�5      $��10 0 0 0q�5      6$   �� 5      $��0��6   $��Right=�6+   	 �� Orientation$	 
Horizontal=�5      .+�5      �� -   5        
 ��Name$
 BtnMinimize��5      $ ��/Assets/ButtonMinimize.png��5      $��25��5      $��25��6    $��0 15 5 0q�5       6&   �� 5!      -   5        $
 BtnClose��5!      $��/Assets/CloseButton.png��5"      $��25��5#      $��0 0 10 0q�5$      6&   5%      5&      �� 5(      $��1��6   $
��1200��6%   $��10��62   ���#4E2590$	��Top=�6M   �� 5)      -   5        $
 BtnHome��5)      $��/Assets/BtnHome.png��5*      $��1��5+      $
��Left=�5,      $��15 0 0 0q�5-      $��50��5.      $��50��5/      6   �� 50      $��1��6   $��Center=�51      $��Center=�52      $��ЖИВОТНЫЕ��53      ���#FCEA4A$��Segoe UI Black)�55      $��32(�56      �� 57      $��1��6   $
��1200��6%   $��10��62   ���#4E2590$��Bottom=�6M   �� 58      -   5         ��Name$ LvAnimal��58      $��2��59      ���#474747$��0q�5;      $��Disabled=�5=      $��5q�5>      ��5?      �� 5@      .R�5A      � 5B      ��5D      �� 5E      .R�5F      �� $ 5��6!   $��1q�5G   !   
���   �$	��300��5I   !   $	��220��5J   !   $��
100 0 0 25q�5K   !   ._�5L      �� .��5M   "   �� .+�5N   &   �� $
 	ImgAnimal��6,   $	��200��5O   (   $	��180��5P   (   ��5Q   *   �� 5R   .    �� Path$ 	PhotoPath�66    �� TargetNullValue 5S   2   ��5T   6   /Assets/NoImageService.png��5V   7   5X   /   5Z   '   �� 5[   &      TblText#���   5\   0   $��18(�5]   0   ���#FCEA4A$��Center=�5_   0   $
��Wrap=�5`   0   ��5[   0   �� *Name+5`   0   �� 5e   &    ��Name$ BtnOpen��6-   -   5          BtnStyle#���  5f   -   $��ОТКРЫТЬ��5g   -   $��0 30 0 0q�5h   -   6?   5i   #   5j      5k      5l      5n      �� 5p      $��3��6   .+�5q      �� -   5         ��Name$ CmbSort��5q      $	��250��5s      $
��Left=�5t      $��5 25 0 0q�5u      6-   5v      5w      5x      5y      