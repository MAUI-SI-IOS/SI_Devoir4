# Fonctionnement
- Docteur ->  a priorite donc il travaille quand il peux
- Nurse, Paramedic -> travaillent quand ils doivents

IDelegate -> {mediateur, delegate, et proxy}
Coordonne la logique, il s'occupe de notifier l'observeur et il s'occupe de changer le state

Teams
est l'observeur il est l'agglomeration d'un equipe sont equipe est composer de lui et lui est composer de son equipe

# SI\_Devoir4

## Devoir 04 – 5 points

## Diagramme classe 3,5 points

## Code 1,5 point

En nous basant sur nos cours portant sur les patrons de conception State, Observer et Delegate, nous combinons trois patrons de conception : Delegate, State et Observer.

Prenons l’exemple de l’hôpital. Chaque délégué (doctor, paramedic, nurse) peut se trouver dans l’un des deux états suivants : TIRED ou NOTTIRED.

Le patron State permet de gérer ces conditions dynamiques afin que, lorsqu’un délégué passe de l’état NOTTIRED à l’état TIRED, le système puisse réagir automatiquement.

Pour rendre ce comportement automatique, nous utilisons le patron Observer, dans lequel les observateurs sont notifiés chaque fois que l’état d’un délégué change(ca peut être par une fonction random avec un timer ..). Lorsqu’un délégué devient fatigué, le système met à jour la délégation. Par exemple, en transférant la responsabilité du doctor vers le paramedic. Ce qui assure la continuité des opérations sans intervention manuelle.



À retenir : un doctor est un observateur d’autres sujets (par exemple le paramedic et le nurse), et chaque paramedic et nurse est, à son tour, un observateur du doctor également.

