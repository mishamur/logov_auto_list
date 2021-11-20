using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_list
{

    public class Item<T>
    {
        /// <summary>
        /// Хранимые данные.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Следующий элемент связного списка.
        /// </summary>
        public Item<T> Next { get; set; }

        /// <summary>
        /// Создание нового экземпляра связного списка.
        /// </summary>
        /// <param name="data"> Сохраняемые данные. </param>
        public Item(T data)
        {
            // Не забываем проверять входные аргументы на null.
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            Data = data;
        }

        /// <summary>
        /// Приведение объекта к строке.
        /// </summary>
        /// <returns> Хранимые данные. </returns>
        public override string ToString()
        {
            return Data.ToString();
        }
    }

    class UserList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Первый (головной) элемент списка.
        /// </summary>
        private Item<T> _head = null;

        /// <summary>
        /// Крайний (хвостовой) элемент списка. 
        /// </summary>
        private Item<T> _tail = null;

        /// <summary>
        /// Количество элементов списка.
        /// </summary>
        private int _count = 0;

        /// <summary>
        /// Количество элементов списка.
        /// </summary>
        public int Count
        {
            get => _count;
        }

        /// <summary>
        /// Добавить данные в конец связного списка.
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            // Не забываем проверять входные аргументы на null.
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            // Создаем новый элемент связного списка.
            var item = new Item<T>(data);

            // Если связный список пуст, то добавляем созданный элемент в начало,
            // иначе добавляем этот элемент как следующий за крайним элементом.
            if (_head == null)
            {
                _head = item;
            }
            else
            {
                _tail.Next = item;
            }

            // Устанавливаем этот элемент последним.
            _tail = item;

            // Увеличиваем счетчик количества элементов.
            _count++;
        }
        /// <summary>
        /// Добавить элемент в указанный индекс
        /// </summary>
        /// <param name="data"></param>
        /// <param name="position"></param>
        public void Add(T data, int position)
        {
            //Проверка корректност индекса
            if(position > Count | position < 0)
                throw new ArgumentNullException(nameof(data));

            // Не забываем проверять входные аргументы на null.
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            // Создаем новый элемент связного списка.
            var item = new Item<T>(data);

            // Если связный список пуст, то добавляем созданный элемент в начало,
            // иначе добавляем этот элемент как следующий за крайним элементом.
            if (_head == null & position == 0)
            {
                _head = item;
                // Устанавливаем этот элемент последним.
                _tail = item;   
            }
            else
            {
                int i = 0;
                var current = _head;
                // Предыдущий элемент списка, перед обозреваемым.
                Item<T> previous = null;
                while (i != position)
                {
                    previous = current;
                    current = current.Next;
                    i++;
                }
                if (previous != null)
                {
                    previous.Next = item;
                    item.Next = current;
                }
                else
                {
                    Item<T> temp = current;
                    _head = item;
                    item.Next = current;
                }
                
            }
            // Увеличиваем счетчик количества элементов.
            _count++;
        }


        /// <summary>
        /// Удалить данные position индекса
        /// </summary>
        /// <param name="position">Данные какой позиции будут удалены</param>
        public void Delete(int position)
        {
            if(position > Count | position < 0)
            {
                throw new ArgumentException();
            }


            int i = 0;
            var current = _head;
            // Предыдущий элемент списка, перед обозреваемым.
            Item<T> previous = null;
            while (i != position)
            {
                previous = current;
                current = current.Next;
                i++;
            }
            if(previous != null)
            {
                previous.Next = current.Next;
            }
            else
            {
                // Устанавливаем головной элемент следующим.
                _head = _head.Next;

                // Если список оказался пустым,
                // то обнуляем и крайний элемент.
                if (_head == null)
                {
                    _tail = null;
                }

            }
            _count--;

        }

        /// <summary>
        /// Удалить данные из связного списка.
        /// Выполняется удаление первого вхождения данных.
        /// </summary>
        /// <param name="data"> Данные, которые будут удалены. </param>
        public void Delete(T data)
        {
            // Не забываем проверять входные аргументы на null.
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            // Текущий обозреваемый элемент списка.
            var current = _head;

            // Предыдущий элемент списка, перед обозреваемым.
            Item<T> previous = null;

            // Выполняем переход по всех элементам списка до его завершения,
            // или пока не будет найден элемент, который необходимо удалить.
            while (current != null)
            {
                // Если данные обозреваемого элемента совпадают с удаляемыми данными,
                // то выполняем удаление текущего элемента учитывая его положение в цепочке.
                if (current.Data.Equals(data))
                {
                    // Если элемент находится в середине или в конце списка,
                    // выкидываем текущий элемент из списка.
                    // Иначе это первый элемент списка,
                    // выкидываем первый элемент из списка.
                    if (previous != null)
                    {
                        // Устанавливаем у предыдущего элемента указатель на следующий элемент от текущего.
                        previous.Next = current.Next;

                        // Если это был последний элемент списка, 
                        // то изменяем указатель на крайний элемент списка.
                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                    }
                    else
                    {
                        // Устанавливаем головной элемент следующим.
                        _head = _head.Next;

                        // Если список оказался пустым,
                        // то обнуляем и крайний элемент.
                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }

                    // Элемент был удален.
                    // Уменьшаем количество элементов и выходим из цикла.
                    // Для того, чтобы удалить все вхождения данных из списка
                    // необходимо не выходить из цикла, а продолжать до его завершения.
                    _count--;
                    break;
                }

                // Переходим к следующему элементу списка.
                previous = current;
                current = current.Next;
            }
        }
        
        /// <summary>
        /// Очистить список.
        /// </summary>
        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        /// <summary>
        /// Вернуть перечислитель, выполняющий перебор всех элементов в связном списке.
        /// </summary>
        /// <returns> Перечислитель, который можно использовать для итерации по коллекции. </returns>
        public IEnumerator<T> GetEnumerator()
        {
            // Перебираем все элементы связного списка, для представления в виде коллекции элементов.
            var current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        /// <summary>
        /// Вернуть перечислитель, который осуществляет итерационный переход по связному списку.
        /// </summary>
        /// <returns> Объект IEnumerator, который используется для прохода по коллекции. </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            // Просто возвращаем перечислитель, определенный выше.
            // Это необходимо для реализации интерфейса IEnumerable
            // чтобы была возможность перебирать элементы связного списка операцией foreach.
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
