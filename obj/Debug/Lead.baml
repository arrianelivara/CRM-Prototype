   M S B A M L   `   `   `  ����C  ?CRMFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:CRMFinalCRMFinal  5          CRMFinal.Lead   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:CRMFinal     5      $��673.701��5   7   $��1233.629��6H   
���   �.��5	      � ���	#FFF9F9F9  � ColumnDefinitions  5
   
   �� 5      $��70 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $	��100 �6   �� 5      $��10 �6   �� 5      $	��100 �6   �� 5      $��10 �6   �� 5      $	��100 �6   �� 5      $��70 �6    � RowDefinitions 5   
   �� 5      $��5 �6   �� 5      $��10 �6   �� 5      $��60 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� $��Leads��6   $��1��6!   $��2��61   $��22(�6>   $��Raleway SemiBold)�6L   $��0,19,0,0q�6j   &   System.Windows.Controls.DataGrid  5!   
   -   5        $��	LeadsDtGd��5!   �      AutoGenerateColumns .  $��3��6�   $��1��6�   $��Raleway SemiBold)�6�   $��12(�6�   $��7��6�   $��1q�6�   ���	#FF9B9B9B   GridLinesVisibility$ 
Horizontal=�6)     VerticalGridLinesBrush �	#FF323232   HeadersVisibility$ Column=�6m     AlternatingRowBackground �	#FFE4E4E4
���������6A   ��    Columns 5"      4  .System.Windows.Controls.DataGridCheckBoxColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$	 All��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 70 66   6C   0  *System.Windows.Controls.DataGridTextColumn  5$      -   5        LeadName��$ 	LEAD NAME��5$   8   $		 150 6K   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6W   �� *	FirstName+6x     5%      -   5        
LeadStatus��$ LEAD STATUS��5%   9   $		 120 6N   
 6Z   �� *
LeadStatus+6{     5&      -   5        CompanyName��$ COMPANY��5&   :   $		 100 6K   
 6W   �� *CompanyName+6y     5'      -   5        JobTitle��$ 	JOB TITLE��5'   7   $		 100 6J   
 6V   �� *
JobTitle+6u     5(      -   5        	Email��$ EMAIL��5(   4   $		 150 6C   
 6O   �� *Email+6k   5  /System.Windows.Controls.DataGridHyperlinkColumn  5)      -   5        	ContactNo��$ 
CONTACT NO��5)   =   $		 110 6Q   
 6]   �� *	ContactNo+6}     5*      -   5        
Adress��$ ADDRESS��5*   5   $		 150 6F   
 6R   �� *	Address+6p     5+      -	   5        	LeadOwner��$ 
LEAD OWNER��5+   8   
 6L   �� *
UserName+6k   5-      �� 5.   
   $��CONVERT��6   $��2��6#   $��2��63   $
��Auto��6@   $��264.816,10,10,10q�6N   ���	#FFF9813D��6   Z� �� 5/   
   -
   5        $��
BtnAddLead��5/   *   $	��ADD��6<   $��3��6J   $��2��6Z   $
��Auto��6g   $
��0,10q�6u   �� 50   
   -   5        $��	btnDelete��50      $��DELETE��6;   $��5��6L   $��2��6\   $
��Auto��6i   $
��0,10q�6w   ���	#FFFF3E3E��6�   Z� �� 51   
   $��2��6   $��1��6    $��122,14,0,12q�60   $��34��6E   $��0,0,0,1q�6Q   .@�52      ��  �� 
IsSelected . .��53   $   	All Leads55      �� 56      .��6   Converted Leads58      �� 59      .��6   
Junk Leads5;      �� 5<      .��6   Mailing Leads5>      �� 5?      .��6   Today's Leads5A      5B      �� 5C   
   $��PRINT��6   $��7��6!   $��2��61   $
��Auto��6>   $
��0,10q�6L   ���	#FF62F154��6q   Z� 5G      5H      