using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt12_4
{
    class Pokupatel
    {
        private string productName;   // Название покупаемого продукта
        private double productPrice;  // Цена продукта
        private int quantity;         // Количество продукта
        private double wallet;        // Кошелек покупателя (наличность)
        private double mood = 10;     // Настроение покупателя

        // Конструктор класса
        public Pokupatel(string productName, double productPrice, int quantity, double wallet)
        {
            
            this.productName = productName;
            this.productPrice = productPrice;
            this.quantity = quantity;
            this.wallet = wallet;
        }

        //отображение информации о покупке
        public void PurchaseInfo()
        {
            Console.WriteLine($"Куплено {quantity} штук товара \"{productName}\" за {quantity * productPrice} руб.");
        }

        public void Buy(int purchasedQuantity)
        {
            // Метод для совершения покупки
            double purchaseCost = purchasedQuantity * productPrice;
            if (wallet >= purchaseCost)
            {
                // Если денег хватает на покупку, увеличиваем настроение на 50% от стоимости покупки
                mood += 0.5 * purchaseCost;
                wallet -= purchaseCost;
                MessageBox.Show($"Совершена покупка. Денег в кошельке: {wallet}.");
            }
            else
            {
                // Если денег не хватает на покупку, уменьшаем настроение на сумму, которой не хватило
                mood -= purchaseCost;
                MessageBox.Show($"Не хватает {purchaseCost - wallet} денег на покупку. Денег в кошельке: {wallet}");
            }
        }

        public void CheckMood()
        {
            string moodState;
            if (mood > 15)
                moodState = "бодрое";
            else if (mood >= 5)
                moodState = "нормальное";
            else if (mood >= -10)
                moodState = "плохое";
            else
                moodState = "депрессивное";

            MessageBox.Show($"Значение настроения покупателя: {mood} ({moodState}).");
        }


    }



}
