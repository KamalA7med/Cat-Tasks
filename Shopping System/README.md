# 🛒 Shopping Cart System (C# Console Application)

## 📌 Overview
This is a simple **Shopping Cart System** built using **C# and Object-Oriented Programming (OOP)** concepts.  
The system allows users to browse products, add/remove items from a cart, and perform checkout with an **Undo feature**.

---

## 🚀 Features
- View available shop products  
- Add items to cart with quantity  
- Remove items from cart  
- View cart in a table format  
- Checkout with total cost calculation  
- Undo last operation (Add / Remove)  
- User balance handling  

---

## 🏗️ Project Structure

### 1. Item
Represents a product in the shop or cart.

**Properties:**
- Name
- Price
- Description
- Quantity

---

### 2. Cart
Manages items added by the user.

**Methods:**
- AddItem()
- Remove()

---

### 3. User
Represents the customer.

**Properties:**
- Name
- Balance
- Cart

---

### 4. Shopping_System_UI
Handles all user interactions.

**Main Functions:**
- ViewCart()
- List_Shop_Items()
- Add_item_To_cart()
- Remove_item_from_Cart()
- Checkout()
- UndoLastOperation()

---

## 🔄 Undo System
The system uses a **Stack** to store operations:
- Add Item
- Remove Item

Each operation can be undone using:

```csharp
UndoLastOperation();
