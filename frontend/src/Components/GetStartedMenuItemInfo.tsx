import React from "react";
import './GetStarted.css';

import GetStartedMenuItemDescription from "./GetStartedMenuItemDescription";
import GetStartedMenuItemTitle from "./GetStartedMenuItemTitle";

interface GetStartedMenuItemInfoProps {
    className?: string;
}


function GetStartedMenuItemInfo({ className }: GetStartedMenuItemInfoProps) {
    return (
        <div className={className}>
          <GetStartedMenuItemTitle />
          <GetStartedMenuItemDescription />
      </div>
  );
}

export default GetStartedMenuItemInfo;