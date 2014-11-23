﻿using System;
using Assemblies.Utilitys;
using LeagueSharp;
using LeagueSharp.Common;

namespace Assemblies {
    internal class Champion : ChampionUtils {
        public Obj_AI_Hero player;
        private readonly WardJumper wardJumper;
        public AntiRengar antiRengar;
        protected Spell E;
        protected Spell Q;
        protected Spell R;
        protected Spell W;
        protected Menu menu;
        protected Orbwalking.Orbwalker orbwalker;

        public Champion() {
            addBasicMenu();
            wardJumper = new WardJumper();
            antiRengar = new AntiRengar();
        }

        private void addBasicMenu() {
            menu = new Menu("Assemblies - " + player.ChampionName, "Assemblies - " + player.ChampionName,
                true);

            var targetSelectorMenu = new Menu("Target Selector", "Target Selector");
            SimpleTs.AddToMenu(targetSelectorMenu);
            menu.AddSubMenu(targetSelectorMenu);

            //Orbwalker submenu
            var orbwalkerMenu = new Menu("xSLx-Orbwalker", "orbwalker");
            XSLxOrbwalker.AddToMenu(orbwalkerMenu);
            menu.AddSubMenu(orbwalkerMenu);

            menu.AddToMainMenu();
        }
    }
}