# Order Notification System

A simple C# console application that simulates placing orders and notifying different services like Email, SMS, and WhatsApp.

The main purpose of this project is to practice working with delegates, events, lambda expressions, extension methods, and predicates in a practical way.

--------------------------------------------------

What the program does

- Creates a list of sample orders
- Places each order using OrderService
- Applies a filter (only orders with high price trigger notifications)
- Notifies multiple services when the condition is met

--------------------------------------------------

Where each concept is used

Delegate

Used a built-in delegate:

public event Action<Order> OnPlacedOrder;

Action<Order> represents methods that take an Order and return nothing.

--------------------------------------------------

Event

Declared here:

public event Action<Order> OnPlacedOrder;

Triggered inside Place_order:

OnPlacedOrder(order);

Subscribed in Main:

service.OnPlacedOrder += Email.Notify;
service.OnPlacedOrder += WhatsApp.Notify;
service.OnPlacedOrder += SMS.Notify;

--------------------------------------------------

Lambda Expression

Used for filtering orders:

service.Filter_Notifactions = (Order O) => O.Price >= 800;

This means only orders with price >= 800 will send notifications.

--------------------------------------------------

Extension Method

Defined here:

public static void format_order_message(this Order order)

Used like this:

order.format_order_message();

This prints the order details in a clean format.

--------------------------------------------------

Predicate / Action / Func

Predicate:

public Predicate<Order> Filter_Notifactions;

Used to decide if the order should trigger notifications.

Action:

public event Action<Order> OnPlacedOrder;

Used for the event (methods with no return value).

Func:

Not used in this project, but could be added if needed.

Example:

Func<Order, bool> check = o => o.Price > 1000;

--------------------------------------------------

Program Flow

1. Orders are created using Get_Orders()
2. Each order is passed to Place_order
3. The filter checks the price
4. If condition is true → event is triggered
5. All subscribed services receive the notification
6. Each service prints the order details

--------------------------------------------------

Notes

- Order class includes basic validation (no negative id or price)
- Extension method keeps formatting separate from main logic
- Event system allows easy adding/removing of services

