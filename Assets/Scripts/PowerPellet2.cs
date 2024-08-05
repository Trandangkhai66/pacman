    using UnityEngine;

    public class PowerPellet2 : Pellet
    {
        public float duration = 8f;

        protected override void Eat()
        {
            GameManager.Instance.PowerPellet2Eaten(this);
        }

    }
