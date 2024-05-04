# OOP.TravelAgency
Мобильное приложение для управления туристическим агентством.
1.	Entity:
•	ID – свойство для хранения идентификатора сущности 
2.	User:
Наследуется от класса Entity
•	Username/mail – логин пользователя для входа 
•	Password – пароль пользователя 
•	ChangePassword() – метод для смены пароля 
•	ReservationBook – список туров в корзине 
3.	Admin:
Наследует все свойства и методы класса User.
•	AddTour() – метод для добавления туров 
•	EditTour() – метод для изменения туров
•	DeleteTour() – метод для удаления туров 
4.	Customer:
Наследует все свойства и методы класса User.
•	Balance – сумма на балансе 
•	AddBalance() – метод для пополнения баланса
•	AddTourToCart() – метод для добавления тура в корзину
•	DeleteTourFromCart() – метод для удаления тура из корзины
•	PayForCart() – метод для оплаты корзины
5.	Tour:
Наследуется от класса Entity
•	Name – название тура
•	Picture – фотоописание тура
•	Price – цена за тур
•	Description – описание тура
6.	BaseView:
•	IsBusy – проверка открыта ли страница уже
7.	MainMenuView: 
Наследуется от класса BaseView.
•	Tours – список отображаемых туров
•	EditBtn – кнопка для изменения туров 
•	EditBtnVisible – определение вида пользователя для доступа к изменению тура
•	SelectTour() – переход к выбранному туру
8.	TourView:
Наследуется от класса BaseView.
•	currentTour – отображаемый тур
9.	LoginView:
Наследуется от класса BaseView.
•	userLogin – ввод логина пользователя 
•	userPassword – ввод пароля пользователя 
•	Login() – метод для входа пользователя
•	Register() – метод для регистрации пользователя 
10.	 CartView:
Наследуется от класса BaseView.
•	balance – отображает баланс пользователя
•	cost – отображает сумму за туры 
•	tours – отображает туры в корзине
•	Buy() – метод для оплаты туров 
•	Delete() – метод для удаления тура из корзины
11.	 ProfileView:
Наследуется от класса BaseView.
•	balance – отображает баланс пользователя
•	userLogin – отображает логин пользователя
•	userPassword – позволяет посмотреть пароль пользователя
•	ChangePassword() – метод для смены пароля 
•	TopUpBalance() – метод для пополения баланса 
