using mercadopago;
using System.Collections;

public class MyClass {
	public static void Main () {
		MP mp = new MP("USER_AT");

		Hashtable payment = mp.post("/v1/payments", "{"+
			"'transaction_amount': 100,"+
			"'token': 'ff8080814c11e237014c1ff593b57b4d',"+
			"'description': 'Title of what you are paying for',"+
			"'installments': 1,"+
			"'payer': {"+
				"'id': 178096989,"+
				"'type': 'customer'"+
			"},"+
	    		"'application_fee': 2.56"+
		"}");
	}
}

