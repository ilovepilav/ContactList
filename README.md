# ContactList

ContactList CQRS, Onion Architecture ve Mediator pattern kullanılarak oluşturulmuş basit CRUD işlemlerinin yapıldığı, UI olarak MVC kullanılan demo bir projedir.

## Installation

Öncelikle projeyi clonelayın.

```


git clone https://github.com/ilovepilav/ContactList.git

```

- Projeyi cloneladıktan sonra ContactList.Persistence altındaki ApplicationDbContext dosyasını kendi database bağlantınıza göre düzenleyin.

- Persistence projesinde migration işlemi yapın.

- Update-Database işlemini yapın.

## Usage

Projeyi cloneladıktan sonra \ContactList\src\UI\ContactList..Web klasörüne gidip dotnet run komutu ile projeyi çalıştırabilirsiniz.

## Todos

- Exception handling
- Proper comments
- Logging

## Contributing

Pull requestler kabul edilir. Büyük değişiklikler için lütfen değiştirmek istediğinizi tartışmak için bir konu açınız.

## License

[MIT](https://choosealicense.com/licenses/mit/)
