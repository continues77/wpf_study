   M S B A M L   `   `   `  ����A  =JrBase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:JrBase.Views.BehaviorsJrBase.Views.Behaviors  5   	   clr-namespace:JrBaseJrBase  5   	   /clr-namespace:JrBase.AppCommJrBase.AppComm  5	   	       JrBase.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5   	   4	behaviors$clr-namespace:JrBase.Views.Behaviors  5   	    localclr-namespace:JrBase  5   	   *appCommclr-namespace:JrBase.AppComm  5	   	   -   5        $��	TopWindow��5   	     � Title$  
MainWindow��5   	   $
��1920��5   	   $
��1000��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowState$ 	Maximized=�5   	   ���	#FF151515 � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � 	Resources 5      1   +JrBase.AppComm.LeftPanelDimensionsConverter   LeftPanelConverter2  ,JrBase.AppComm.RightPanelDimensionsConverter  RightPanelConverter-  'JrBase.AppComm.LeftPanelMarginConverter  LeftMarginConverter.  (JrBase.AppComm.RightPanelMarginConverter  RightMarginConverter  OpenLeftSideBar �� TargetProperty g� AccelerationRatio g� DecelerationRatio	 �� 
TargetName
 g� Duration W� From	 W� To `� 	Converter �� Mode �� ElementName �� Path  CloseLeftSideBar  OpenRightSideBar  CloseRightSideBar��%�  &	        &	      &	 &     &	 9     &	 L     7   &	 �    7   &	 �    7  &	     7    5   
   6/     5   
   60     5   
   6+     5   
   6,   �� 5   
   $, &RenderTransform.(TranslateTransform.X)�5      $ .4Q�5      $ .4Q�5      .��5       W� $	 LeftsidePanel��6   $
 0:0:0.2D�6D    06W    5!      `� 5"      8   .1�5#      �� $ OneWay=�6"   $ LeftPropertiesPanel��60   $ Width�6R   5$      5&      5'      �� 5)   
   $, &RenderTransform.(TranslateTransform.X)�5*      $ .4Q�5+      $ .4Q�5,      .��5-      W� $	 LeftsidePanel��6   $
 0:0:0.1D�6D    06W    5.      `� 5/      8   .1�50      �� $ OneWay=�6"   $ LeftPropertiesPanel��60   $ Width�6R   51      53      54      �� 56   
   $, &RenderTransform.(TranslateTransform.X)�57      $ .4Q�58      $ .4Q�59      .��5:      W� $	 RightsidePanel��6   $
 0:0:0.2D�6E    06X    5;      `� 5<      8   .1�5=      �� $ OneWay=�6"   $ RightPropertiesPanel��60   $ Width�6S   5>      5@      5A      �� 5C   
   $, &RenderTransform.(TranslateTransform.X)�5D      $ .4Q�5E      $ .4Q�5F      .��5G      W� $	 RightsidePanel��6   $
 0:0:0.1D�6E    06X    5H      `� 5I      8   .1�5J      �� $ OneWay=�6"   $ RightPropertiesPanel��60   $ Width�6S   5K      5M      5N      5O      .��5Q      � .+�5R   
   �  � RowDefinitions 5S      �� 5U      $��0.09* �6    �� 5W      $��1* �6    �� 5Y      $��0.075* �6    .+�5]      � $��1��6   
���   �.+�5^       �   � NavigationUIVisibility$ Hidden=�6   
�������*  $Microsoft.Xaml.Behaviors.Interaction   	Behaviors 5_      *   $JrBase.Views.Behaviors.FrameBehavior  5`         NavigationSource 62   �� *NavigationSource+$ TwoWay=�5b      5c      � 5f      $��2��6   
���   � � ColumnDefinitions 5g      �� 5h      $
��0.4* �6'   �� 5i      �� 5j      �� 5k      �� 5l      �� 5m      �� 5n      $
��0.4* �6'   .+�5p      �� -   5         ��Name$ btnSet��5p   )   $��0��6   ���	#FF303030
�������.��5r      �� $��/Images/Setup.png��6   $��Uniform=�67   $��60��6I    � Triggers 5s      :� 5t       :� RoutedEvent$ Button.Click��6'   .[�5u      �� #��[ 6.   5v      5x      �� 5y      -   5        $ btnMain��5y   )   $��1��6   $��30(�6:   $
��Bold"�6H   ���	#FF303030
�������$ ��Views/MainUI/viewMain.xaml��5}      ��5{      ��   DR �� Source# [ $ 
[wrd_Main]���5|      �� *NavigateCommand+ 5~      :� 5      $ Button.Click��6'   .[�5�      �� #��[ 6.   5�      5�      �� 5�      -   5        $ btnStart��5�   )   $��2��6   $��30(�6;   $
��Bold"�6I   ���	#FF303030
�������$��START��5�      ��5�      �� # [ $ [wrd_Start]���5�      �� *ButtonCommand+5�      �� 5�      -   5        $ btnStop��5�   )   $��3��6   $��30(�6:   $
��Bold"�6H   ���	#FF303030
�������$
��STOP��5�      ��5�      �� # [ $ 
[wrd_Stop]���5�      �� *ButtonCommand+5�      �� 5�      -   5        $ btnReset��5�   )   $��4��6   $��30(�6;   $
��Bold"�6I   ���	#FF303030
�������$��RESET��5�      ��5�      �� # [ $ [wrd_Reset]���5�      �� *ButtonCommand+5�      �� 5�      -   5        $ btnExit��5�   )   $��5��6   $��30(�6:   $
��Bold"�6H   ���	#FF303030
�������$
��EXIT��5�      ��5�      �� # [ $ 
[wrd_Exit]���5�      �� *ButtonCommand+5�      �� 5�      -   5        $ btnList��5�   )   $��6��6   ���	#FF303030
�������.��5�      �� $��/Images/List.png��6   $��Uniform=�66   $��60��6H    5�      :� 5�      $ Button.Click��6'   .[�5�      �� #��[ 6.   5�      5�      5�      5�      �� 5�   
   -	   5         ��Name$ LeftsidePanel��5�      $
��Left=�6,   ��5�      �� $ LeftPropertiesPanel��$ Width� �� 	Converter# [ z�5�      T� 5�      .+�5�      ��  �� Orientation$ 
Horizontal=�6   $��
-300,0,0,0q�62   .+�5�      �� $ Vertical=�6   ���	#E0303030.+�5�      � -
   5         �Name$ LeftPropertiesPanel��5�      $	��300��68   ��6D   �� *Height+$ 	TopWindow�� 5�      �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,    5�       �� 
TargetType �� Property  �� Value��%~   '��       �� 5�      " ��6$   .�5�   "   ��  � ��$	  250��6:   �� 5�   "    � ��$  	0,15,0,15q�6;   5�      5�      .+�5�      �� $��Setup��6$   $��0��61   $
��Bold"�6>   
�������$��Center=�6i   $��0,5,0,5q�6�   $��20(�5�   $   �� 5�      -   5        $ 	btnRecipe��5�   .   $��1��6!   $��	10,2,10,2q�6A   ���	#FF151515
�������$"��Views/MainUI/viewRecipe.xaml��5�      ��5�      �� *NavigateCommand+ 5�      :� 5�   "   $ Button.Click��6/   .[�5�   &   �� #��[ 66   5�   #   .��5�      �� .+�5�   "   �� $��20(�5�   ,   
�������$
��Bold"�6R   ��5�   ,   �� # [ $ [wrd_Recipe]�5�   R   �� 5�   "   $��15(�5�   ,   
���������5�   ,   �� # [ $ [tool_Recipe]�5�   :   5�      5�      �� 5�      -   5        $ 	btnManual��5�   .   $��2��6!   $��	10,2,10,2q�6A   ���	#FF151515
�������$"��Views/MainUI/viewRecipe.xaml��5�      ��5�      �� *NavigateCommand+ 5�      :� 5�   "   $ Button.Click��6/   .[�5�   &   �� #��[ 66   5�   #   .��5�      �� .+�5�   "   �� $��20(�5�   ,   
�������$
��Bold"�6R   ��5�   ,   �� # [ $ [wrd_Manual]�5�   R   �� 5�   "   $��15(�5�   ,   
���������5�   ,   �� # [ $ [tool_Recipe]�5�   :   5�      5�      5�      5�      5�       5�      :� 5�      $$ StackPanel.MouseLeftButtonDown��6   .[�5�      �� #��[ 6&   5�      5�      �� 5�   
   -   5        $ RightsidePanel��5�      $��Right=�6-   ��5�      �� $ RightPropertiesPanel��$ Width�# [ z�5�      T� 5�      .+�5�      �� $ 
Horizontal=�6   $��
0,0,-300,0q�62   .+�5�      �� $ Vertical=�6   ���	#E0303030.+�5�      � -   5        $ RightPropertiesPanel��5�      $	��300��69   ��6E   �� *Height+$ 	TopWindow��5�      5�      5�       5�      :� 5�      $$ StackPanel.MouseLeftButtonDown��6   .[�5�      �� #��[ 6&   5�      5�      5�      5�      