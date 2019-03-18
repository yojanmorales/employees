
import React from 'react';
import ReactDOM from 'react-dom';
import {Provider} from 'react-redux';

import './index.css';
import 'bootstrap/dist/css/bootstrap.css';
// Initial action to load merchant list from API
import { getEmployees } from './actions/actions';
// Store config
import configureStore from './store/configureStore';
// Service Worker
import registerServiceWorker from './serviceWorker';
// App component
import App from './App';

const store = configureStore();
// Load merchant list from API as soon as application initiates
store.dispatch(getEmployees());

ReactDOM.render(
    <Provider store={store}>
        <App />
    </Provider>,
    document.getElementById('root')
);

registerServiceWorker();