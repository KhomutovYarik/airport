# PSU-control_room

Базовый функционал который есть у всех:
у игрока есть самолеты и контракты на перевозку грузов или пассажиров. У каждого перелета есть цена, если рейс пустой(без контракта, чтобы перегнать самолет в другой город у него отрицательная цена). Нужно иметь возможность ставить расписание полетов, время то же что на компьютере. Не выполненный рейс требует выплаты неустойки.
Требования к интерфейсу: должна быть возможность просматривать доступные рейсы, выбирать понравившиеся и как-то ставить их в расписание. При выборе рейса должна быть информация по месту, времени либо частоте перевозки, требуемой грузоподъемности( кол-ву пассажиров), цене перевозки и неустойке.

Функционал на выбор:
1. ⏰ Реализовано игровое время, его можно ускорять, игровые действия к нему привязаны.

2. ✈ Игрок может покупать/ продавать самолёты. Также можно брать их в аренду/лизинг. Самолёты бывают разной грузоподъемности/пассажировместительности. Разной допустимой дальности.

3. 📋 Игрок выбирает рейсы, которые расставляет в расписание по своим самолетам на рынке контрактов. Приложение должно учитывать соответствие самолета рейсу( по дальности тоже). Рейсы бывают пассажирские/грузоперевозки. Пассажирские рейсы бывают регулярные(прямой-обратный), разовые. Рейсы генерируются раз в день.

4. 💰 Стоимость пассажирского рейса зависит от времени, когда его поставил игрок. Грузовой рейс имеет фиксированную стоимость. Из дохода от рейса вычитаются расходы на него, они зависят от самолета(более вместительный дороже).

5. ⛽ Цена на топливо колеблется. Топливо влияет на цену перелёта самолета( характеристика самолета расход на километр)

6. Самолёты изнашиваются. Это влияет на их стоимость. Кроме того чем больше износ тем дороже обслуживание самолета.

7. Рынок самолётов. Цены меняются зависимости от спроса. Оценивается количество купленных/проданных самолётов у игрока и конкурентов ( оценивается популярность конкретной марки/модели) за последнее время.

8. Рынок труда. На каждый самолёт требуется какой-то экипаж( количество это характеристика самолета). Экипажу устанавливает зарплату игрок. В зависимости от ситуации на рынке( зарплаты у конкурентов) на объявленную пользователем ставку оценивается спрос. Должности могут не заполняться если зарплата низкая, либо не все требуемые если средняя. Т.е. у членов экипажа может быть разная зарплата.Если самолёт продают экипаж увольнять экипаж надо отдельно. Можно менять членов экипажа между самолетами( увольнять тех, что дороже). Если экипажу платят мало( у конкурентов сильно больше) могут быть забастовки.

9. Необходимо реализовать Конкурентов( либо игру по сети)у которых есть стратегии поведения на рынке целью максимизации прибыли. Конкуренты могут заказывать забастовку и антирекламу вашей компании. То же самое доступно и игроку.

10. На популярность перелёта влияют не только его выгодные часы, но и имидж данной авиакомпании. На имидж влияют описанные ранее условия плюс реклама. Забастовки, антиреклама, старые самолёты имидж снижают. Высокая зарплата экипажа улучшает имидж авиакомпании.