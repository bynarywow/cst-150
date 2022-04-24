https://youtu.be/5glBVfnhlx8
This video goes over my project's code and functionality.

The code is located here: https://github.com/bynarywow/cst-150/tree/main/mmelichar_Topic7_Milestone4

The Inventory class contains a constructor using four inputs, two ints, a string, and a double, as well as an overridden ToString method, and get/set methods.

My app.cs file is where the functionality of the program is located. This includes my methods for adding and removing items, restocking items, displaying the whole inventory, and searching for items based on their sku and description.

My main form's code is where the app.cs code gets to be used and we can validate data before it gets passed to the app.cs code. Each button is aptly named and refreshes the inventory list in the data grid view featured on the bottom of the application. Pressing the restock item button opens a secondary dialog that asks for sku and quantity to restock, adding that amount to the original quantity. The search button only matches items based on both sku and description being correct. It will return either the item or a message saying that the item was not found in a messagebox popup. 

The secondary form's code is solely there to pass back the information from the sku and quantity text boxes back to the main form to use in our restockItem method. Once the user presses the restock button at the bottom, the form closes and the quantity they input for restocking will be applied to the sku that they wanted to modify, and changes will be displayed immediately.