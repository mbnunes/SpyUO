   M S B A M L   `   `   `  ���� @  <SpyUO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Ultima.Spy.ApplicationUltima.Spy.Application  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35eDclr-namespace:System.Windows.Media.Imaging;assembly=PresentationCoreSystem.Windows.Media.Imaging '    !Ultima.Spy.Application.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5this$clr-namespace:Ultima.Spy.Application     9system&clr-namespace:System;assembly=mscorlib     XimagingDclr-namespace:System.Windows.Media.Imaging;assembly=PresentationCore     -     J� SnapsToDevicePixels  .  � UseLayoutRounding .  � Icon$  /SpyUO;component/SpyUO.ico�� � Title$ 	SpyUO 2.0��$	��600��$	��800�� � WindowStartupLocation$ CenterScreen=� � DataContext ��  �� RelativeSource �� *Self+ � 	Resources    MainRibbonButton �� 
TargetType  RibbonButton	 �� BasedOn
 �� Property �� Value  MainRibbonToggleButton  RibbonToggleButton  MainRibbonButtonImage  MainRibbonButtonText  MainRibbonSeparator  ButtonDisabledForeground  MainSidePanelSplitter 	 PanelBackground 
 MainSidePanel  DefaultTabControl  MainSidePanelImage  
MainFooter  MainFooterSeparator  MainFooterFilterText  PanelForeground  MainLoadingAnimation g� RepeatBehavior g� 	BeginTime �� 
TargetName �� TargetProperty O� KeyTime O� Value  MainLoading �� EndPoint �� 
StartPoint � Color � Offset  MainFooterButton  DefaultButton  MainGrid&   System.Windows.Controls.DataGrid  DefaultDataGrid  MainNotificationsClear  MainNotificationText  ReadOnlyTextBox  MainNotificationSplitter  MainNotificationImageColumn  NotificationImageConverter �� 	Converter  MainNotificationDetails �� Mode  MainNotificationGrid  MainNotificationCell��%�	  &	        7  &	 ?     7  &	 ~     &	 �     &	 �     7  &	 C    7 	 &	
 �    7  &	 ,    &	 �    7 	 &	 �    7  &	     7  &	 Q    &	 �    &	 �    7  &	 >    7  &	 �    7  &	 �    7  7  &	 %    7 	 &	 �    7  &	 "    7  &	 V    7  7  &	     �� " ��8	   .��� 
 � ��$ 42���� 
 � ��$	 2,2q��� " d�8	   .��� 
 � ��$ 42���� 
 � ��$	 2,2q��� " ��.��� 
 � ��$ 32���� 
 � ��$ 32���� 
 � ��$ Center=��� " ��.��� 
 � ��$ Center=��� " ��.��� 
 � ��8   �� 
 � ��$ 1���� 
 � ��$	 0,4q��� " ��.��� 
 � ��8   �� 
 � ��$ 3���� 
 �@��ResizeBehavior$ PreviousAndNext=��� 
 �@��ResizeDirection$ Columns=��� " ��8	   .��� 
 �@��TabStripPlacement$ Right=��� 
 � ��$ 2,2,0,2q��� " ��.��� 
 � ��$ 16���� 
 � ��$ 16���� 
 � ��$ Center=��� 
 � ��$ Center=��� " ��.��� 
 � ��8   �� " ��.��� 
 � ��8   �� 
 � ��$ 1���� 
 � ��$	 0,2q��� " ��.��� 
 � ��8   �� 
 � ��$ Center=��� 
 � ��$ 2q��� $ Forever��.��U� $ 00:00:00X�$ Loading��$9 3(UIElement.RenderTransform).(RotateTransform.Angle)�.\��� $ 00:00:02��$	 360Q��� " A�.��� 
 � y�$ 	Collapsed=��� 
 � ��$ 5���� 
 �@J�RenderTransformOrigin$ 0.5,0.5&��� 
 � ��$ 2q��� 
 � ��$ 20���� 
 � �� �� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFF0F0F0��$ 0Q�� $ 	#00FFFFFF��$ 1Q��� " ��8	   .��� 
 � ��$ 22���� 
 � ��$	 2,2q��� 
 � ��$ 1q��� "  8	   .��� 
 � ��$ Hidden=��� 
 � ��$
 Auto=��� " ��8	   .��� 
 � ��$ 18���� 
 � ��$ 18���� 
 � ��$ 1q��� " ��8	   .��� 
 � ��8  �� 
 � ��$	 Top=��� 
 � ��$ 2q��� " ��.��� 
 � ��8   �� 
 � ��$ 3���� 
 � ��$ Stretch=��� 
 �@��ResizeBehavior$ PreviousAndNext=��� 
 �@��ResizeDirection$
 Rows=��� 
 � y�$ 	Collapsed=��� .R��� $��1q�$
��None=����� *Type+8   �� .R��� 8��  ���� *	Message+$ OneWay=��� "  8	   .��� 
 � ��$ Hidden=��� 
 � ��$
 Auto=���  
 �@ RowDetailsVisibilityMode$ VisibleWhenSelected=��� 
 �@ RowDetailsTemplate8  �� 
 � y�$ 	Collapsed=��� " ��.��� 
 � ��$ Center=��� 
 �@��Padding$ 2q� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command$	 New��  -   $
 Save��  -   $
 Open��  -   $ this:UltimaCommand.Start��  -   $ this:UltimaCommand.Attach��  -   $ this:UltimaCommand.Pause��  -   $ this:UltimaCommand.Stop��  -	   $( "this:UltimaCommand.CopyToClipboard��  -
   $( "this:UltimaCommand.OpenInNewWindow��  -   $&  this:UltimaCommand.GenerateClass��  -   $&  this:UltimaCommand.FindRelatives��.���    WindowBackground#��[   � RowDefinitions �� $��60 ��� $��* ��� $��24 � � ColumnDefinitions �� $��* ��� $
��Auto ��� -    ��Name$ SidePanelColumn��$	��250 �.+�� $��0��$��0��$��3��#��[	  �� $��* ��� $
��Auto �.+���  �� Orientation$ 
Horizontal=�.+��� #��[  $	��New�� � ToolTip$ Clear packets��.���� .+��� $��Images/Page.png��#��[ �� $	��New��#��[ �� #��[  $
��Open��$# Open packets from binary file��.���� .+��� $��Images/Folder.png��#��[ �� $
��Open��#��[ �� #��[  $
��Save��$! Save packets to binary file��.���� .+��� $��Images/Save.png��#��[ �� $
��Save��#��[ �� #��[ �� #��[  $��this:UltimaCommand.Start��$# Start spying on a new process��{��� *SpyHelper.CanStart+.���� .+��� $��Images/Start.png��#��[ �� $��Start��#��[ �� #��[  $��this:UltimaCommand.Attach��$# Attach spy to running process��{��� *SpyHelper.CanAttach+.���� .+��� $��Images/Attach.png��#��[ �� $��Attach��#��[ �� #��[  $��this:UltimaCommand.Pause��$ 	Pause spy��{��� *SpyHelper.CanPause+.���� .+��� $��Images/Pause.png��#��[ �� $��Pause��#��[ �� #��[  $��this:UltimaCommand.Stop��$ Stop spy��{��� *SpyHelper.CanStop+.���� .+��� $��Images/Stop.png��#��[ �� $
��Stop��#��[ �� #��[ d� #��[ $ Toggle filter on/off�� d� 	IsChecked �� *Filter.Active+$ TwoWay=�.���� .+��� $��Images/Filter.png��#��[ �� $��Filter��#��[ �� -     ��Name$  ClilocButton��#��[  $ Show cliloc browser��.���� .+��� $��Images/Book.png��#��[ �� $��Clilocs��#��[ �� -   $  LootAnalyzerButton��#��[  $ Show loot analyzer��{�.  .���� .+��� $��Images/Briefcase.png��#��[ �� $
��Loot��#��[ �� $��1��$ 
Horizontal=�.+��� -   #��[  $ 
Submit bug��.���� .+��� $��Images/Bug.png��#��[ �� $	��Bug��#��[ �� -   #��[  $ About application��.���� .+��� $��Images/Information.png��#��[ �� $��About��#��[ � $��1��$��0�� �� $��* ��� $
��Auto ��� -   ! ��Name$! NotificationRow��$
��Auto �.+�  -   "  Name$" PacketsView��$��0��#��[ ���� *SpyHelper.Packets+#   Columns# 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn$   Header$
$ Time��1  +System.Windows.Controls.DataGridBoundColumn%   Binding% �� & �� Path$& DateTime�' �� StringFormat$' {0:H:mm:ss fff}��  $$ 	Direction��% �� $& 
FromClient� "! UltimaPacketDirectionConverter# [!   $$ ID��% �� $	& Ids�  $$ Length��% �� $& Data.Length�  $
$ Name��% �� $
& Name�  $$ Content��(   Width5  /System.Windows.Controls.DataGridLengthConverter$( * % �� �� -   ) ��Name$) NotificationSplitter��$��1��$��0��#��[ $��Stretch=�  -   $" NotificationView��$��2��#��[ ���� *Notifications+# 4  .System.Windows.Controls.DataGridTemplateColumn  *   CellTemplate#* [ +   CanUserResize+ .  $ �� -   #��[ $ Clear notifications��.���� $#��Images/NotificationsClear.png��  $( * $$ Notification��,   ElementStyle#, [ % �� $& Title�  $$ Notification Time��#, [ % �� $& DateTime�$' {0:H:mm:ss fff}���� $��1��$��1��#��[ �� -   - ��Name$- 	SidePanel��$��1��$��2��#��[
 . �� SelectedIndex$. 1��.@���  " DefaultTabItem#��[" ���� $��Images/Cancel.png��#��[ �� #��[" ���� $ 
Horizontal=�.+��� $��Images/Properties.png��#��[ �� $��
Properties��$��2,0,0,0q�.��7   1Ultima.Spy.Application.UltimaPacketPropertiesView  -   /  Name$/ PropertiesView��0   Packet0 �� 1 �� ElementName$1 PacketsView��$& SelectedValue��� #��[" ���� $ 
Horizontal=�.+��� $��Images/Binary.gif��#��[ �� $��Binary��$��2,0,0,0q�.��3	   -Ultima.Spy.Application.UltimaPacketBinaryView	  -   2 	 Name$2 
BinaryView��3 	  Packet3 �� $1 PacketsView��$& SelectedValue��� #��[" ���� $ 
Horizontal=�.+��� $��Images/Filter.png��#��[ �� $��Fitler��$��2,0,0,0q�.��3
   -Ultima.Spy.Application.UltimaPacketFilterView
  -   4 
 Name$4 
FilterView���� $��2��$��0��$��3��#��[ ._��  �� $��24 ��� $��24 ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��3 �.+�d� -   5 d�Name$5 NotificationButton��$��0�� # ToolbarToggleButton#��[# $% Show or hide notification panel��.���� $��Images/Notifications.png�� $ ToolbarButtonImage#��[$ A� -   6 A�Name$6 Loading��$��1��#��[ z��� �� $��2��#��[ �� $��3��$
��Spy:��#��[ �� $��4������ " ��#	 [ .��� 
 � ��$ Inactive��7 �� Triggers7 �� 8 �� Binding8 �� *SpyHelper.Active+9 �� Value9 True.a��� 
 � ��$ 	Spying on���� $��5��#��[ ���� *SpyHelper.Path+�� $��6��$��Packet count:��#��[ �� $��7��#��[ ���� *SpyHelper.Count+