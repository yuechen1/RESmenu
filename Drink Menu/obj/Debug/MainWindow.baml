   M S B A M L   `   `   `  ����E  ADrink Menu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Drink_Menu
Drink_Menu  5   	       Drink_Menu.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Drink_Menu     5   	     � Title$  
MainWindow��5   	   $	��720��6   $	��480��6)   .��5	      �� $
��Left=�6   $	��720��6,   $	��Top=�69   $	��470��6Q   $��	0,0,0,-31q�6]   .+�5
   
   �� $
��Left=�6   $��50��60   $	��Top=�6<   $	��470��6T    �� Orientation$ 
Horizontal=�6`   .+�5      �� -   5         ��Name$ menuSelector��5      $��50��6F   $	��Top=�6R   $��50��6j   .��5      �� .+�5      �� -   5         ��Name$ 	iconimage��5      $%��Resources/images/drinkimage.png��6/    �� BitmapScalingMode$
 Fant=�6X   $��50��6   $��50��6�   $
��Fill=�6�   $	��Top=�6�   $
��Left=�6�   $��0,0,0,0q�6�   5      5      �� 5      -   5         ��Name$ txtRestName��5      $
��Left=�6-   $��50��6H   $
��Wrap=�6T   $	��319��6h   $��Segoe UI Black)�6t   $��34(�6�   ���	#FF630C0C K� ZIndex$ -2��6�   $��0q�6�   
���   ��� 6�   $�Dancing Shamrock��6�   6  �� 5      -   5        $ btnCall��5      $
��Call��6<   $��50��6K   $	��Top=�6W   $��50��6o   �� 5      -   5        $ btnBill��5      $
��Bill��6<   $��50��6K   $	��Top=�6W   $��50��6o   5      � 5   
   $
��Left=�6   $	��637��6*   $	��470��67   .+�5      �� -   5         ��Name$ Menushow��5      $ 
Horizontal=�6+   $	��720��6D   $��0��6Q   $ 1��6[   $
��Left=�6l   .+�5      �� $ Vertical=�6   $	��720��64   $	��234��6A   $
��Left=�6M   ���	#FF303030.+�5      �� -   5        $ 	DrinkMain��5      {�.  .��5      �� $ 
Horizontal=�6%   $	��100��6>   $	��234��6K   $
��Left=�6W    J� Opacity$	 0.5Q�6r   .+�5      �� $%��Resources/images/drinkimage.png��6$   $
 Fant=�6M   $	��100��6t   $	��100��6�   �� 5      -   5        $ DrinkMain_text��5   (   $��Drinks��6@   
���   �$��40(�6a   $ 1Q�6o   5      5      �� 5      -	   5        $ 
DinnerMain��5      {�. $ 1Q�6[   .��5      �� $ 
Horizontal=�6%   $	��100��6>   $	��234��6K   $
��Left=�6W   .+�5      �� $%��Resources/images/stakeimage.png��6$   $
 Fant=�6M   $	��100��6t   $	��100��6�   �� 5       -
   5        $ DinnerMain_text��5    (   $��Dinner��6A   
���   �$��40(�6b   5!      5"      �� 5#      -   5        $ 
BurgerMain��5#      {�. $ 1Q�6[   .��5$      �� $ 
Horizontal=�6%   $	��100��6>   $	��234��6K   $
��Left=�6W   .+�5%      �� $&�� Resources/images/burgerimage.png��6$   $
 Fant=�6N   $	��100��6u   $	��100��6�   �� 5&      -   5        $ BurgerMain_text��5&   (   $��Burger��6B   
���   �$��40(�6c   5'      5(      5)      �� 5*      -   5        $ quitmenu��5*      $	��720��6B   $	��236��6O   $ 0Q�6[   5+       � 5,      -   5        	  �Name$	 pagename_drinkpage��5,      
  � Source$
 pageDrink.xaml?�61   $	��670��6I    � 5-      -   5        $	 pagename_stackpage��5-      $
 pagestake.xaml?�61   $��0��6I   5.      5/      51      