import React from "react";
import GetStartedMenuItem from "./GetStartedMenuItem";
import './GetStarted.css';

interface GetStartedMenuProps {
    className?: string;
}

function GetStartedMenu({ className }: GetStartedMenuProps) {
    return (
        <div className={className}>
            <GetStartedMenuItem className="get-started-menu-item"/>
            <GetStartedMenuItem className="get-started-menu-item" />
            <GetStartedMenuItem className="get-started-menu-item" />
            <GetStartedMenuItem className="get-started-menu-item" />
            <GetStartedMenuItem className="get-started-menu-item" />
        </div>
    );
}
export default GetStartedMenu;