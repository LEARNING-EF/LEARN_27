Id		ParentId	Code (Auto)	Path		Level		Name

x		null		1			1\			1			AC1

y		null		2			2\			1			AC2

z		x			3			1\3\		2			AC11

t		x			4			1\4\		2			AC12

m		y			5			2\5\		2			AC21

n		z			6			1\3\6\		3			AC21

AccountCode	1--N	Transactions

var transactions =
	databaseContext.Transactions
	.Where(current => current.AccountCode.Id = ...)
	.ToList()


var transactions =
	databaseContext.Transactions
	.Where(current => current.AccountCode.Path.StartWith == "1\3\")
	.ToList()
	;

توجه

ما به یک جدول تنظیمات نیاز داریم که در ابتدای اجرای اولیه پروژه
از کاربر خواهد پرسید که کلا چند لایه دارد
و در هنگام تعریف لایه‌ها، اجازه تعریف لایه‌هایی بیش از اندازه اولیه
امکان‌پذیر نباشد
