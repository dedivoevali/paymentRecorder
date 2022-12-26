import {Layout} from 'pages/layout';
import {LoginPage} from 'pages/login';
import React from 'react';
import {Route, Routes} from "react-router-dom";
import "./App.css";
import {RouteGuardAuthRequired, RouteGuardUnauthorizedOnly} from "./lib/routeGuards";
import {AllOrdersPage, CreateOrderPage, OrderPage} from "../pages/orders";
import MainPage from "../pages/main/MainPage";
import {NotFoundPage} from "../pages/not-found";

function App() {


    return (
        <div className="App">
            <Routes>
                <Route path="/" element={<Layout/>}>
                    <Route path="/login" element={<RouteGuardUnauthorizedOnly children={<LoginPage/>}/>}/>
                    <Route path="/orders" element={<RouteGuardAuthRequired children={<AllOrdersPage/>}/>}/>
                    <Route path="/orders/:orderNumber" element={<RouteGuardAuthRequired children={<OrderPage/>}/>}/>
                    <Route path="/orders/create-new" element={<RouteGuardAuthRequired children={<CreateOrderPage/>}/>}/>
                    <Route path="/" element={<RouteGuardAuthRequired children={<MainPage/>}/>}/>
                    <Route path="*" element={<NotFoundPage/>}/>
                </Route>
            </Routes>
        </div>
    );
}

export {App};
