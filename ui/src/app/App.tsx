import { Layout } from 'pages/layout';
import { LoginPage } from 'pages/login';
import React, { useEffect } from 'react';
import {Routes,Route} from "react-router-dom";
import "./App.css";
import {RouteGuardAuthRequired, RouteGuardUnauthorizedOnly} from "./lib/routeGuards";

function App() {


    return (
    <div className="App">
        <Routes>
            <Route path="/" element={<Layout/>}>
                <Route path="/login" element={<RouteGuardUnauthorizedOnly children={<LoginPage/>}/>}/>
                <Route path="/orders" element={<RouteGuardAuthRequired children={<div>aaa</div>}/>}/>
            </Route>
        </Routes>
    </div>
);
}

export {App};
