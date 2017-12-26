import { Component, OnInit, ViewEncapsulation } from '@angular/core';

@Component({
    selector: 'app-sidebar',
    styleUrls: ['sidebar.component.scss'],
    templateUrl: 'sidebar.component.html',
    host: {
        'class': 'sidebar',
    },
    encapsulation: ViewEncapsulation.None,
    preserveWhitespaces: false
})

export class SidebarComponent implements OnInit {
    items: SidebarItem[];
    constructor() { }

    ngOnInit() {
        this.items = this.getItems();
    }

    getItems(): SidebarItem[] {
        let items: SidebarItem[] = [];
        items.push(new SidebarItem("Home", "/"))
        items.push(new SidebarItem("My notes", "/notes"))
        return items;
    }
}

export class SidebarItem {
    constructor(private title: string, private route: string, private iconClass?: string) { }
}