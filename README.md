# massacre-unity-game
# 🥊 Immersive Head Punch System

### ⚙️ Тестовое задание для Mineral Inc.

https://github.com/user-attachments/assets/371152de-1996-4a3d-bc6b-d4e8d772eb64

---

## 💡 Описание проекта:

Реалистичная и стилизованная система ударов в голову, выполненная в Unity с использованием **URP**, **Shader Graph**, **DOTween**, **Zenject** и стейт-машины.

---

## 🔑 Ключевые особенности:

* ✅ **Иммерсивные удары по голове**
  Реалистичная деформация меша в точке удара с учётом направления и силы.

* ✅ **Шейдер обратной связи**
  Визуальные эффекты при попадании:

  * Деформация головы (Vertex Position)
  * Красное пятно (Albedo)
  * Подсветка области удара (Emission)

* ✅ **Анимации перчаток**
  У каждой перчатки свой Animator и собственный триггер `Punch`.

* ✅ **Физическая и визуальная обратная связь**
  Тряска камеры (через DOTween `DOShakePosition`)

* ✅ **Интеграция с Zenject**
  Все компоненты внедряются через `Installer` и идентификаторы `Id`

---

## 🧠 Используемые технологии:

* Unity (URP, Shader Graph)
* DOTween (Camera shake)
* Zenject (DI & State Machine)
* Shader Graph (Visual deformation)

