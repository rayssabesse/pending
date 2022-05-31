import 'react-native-gesture-handler';
import { GestureHandlerRootView } from "react-native-gesture-handler";

import React, { Component } from 'react';

import { NavigationContainer } from '@react-navigation/native';
import { createStackNavigator } from '@react-navigation/stack';

import { StatusBar, StyleSheet } from 'react-native';

import clients from './src/screens/clients';
import Login from './src/screens/login';
import signUp from './src/screens/signUp';
import first from './src/screens/first';
import Perfil from './src/screens/perfil';
import Home from './src/screens/main';
import Clients from './src/screens/clients';

// import CameraPerfil from './src/screens/camera';

const AuthStack = createStackNavigator();

class App extends Component {
  render() {
    return (
      <NavigationContainer>
        <AuthStack.Navigator>
          <AuthStack.Screen
            name='First'
            options={{ headerShown: false }}
            component={first}
          />
          <AuthStack.Screen
            name='Login'
            options={{ headerShown: false }}
            component={Login}
          />
          <AuthStack.Screen
            name='Main'
            options={{ headerShown: false }}
            component={Home}
          />

          <AuthStack.Screen
            name='SignUp'
            options={{ headerShown: false }}
            component={signUp}
          />
          <AuthStack.Screen
            name='Clients'
            options={{ headerShown: false }}
            component={Clients}
          />

        </AuthStack.Navigator>
      </NavigationContainer>
    );
  }
}

const styles = StyleSheet.create({
  main: {
    flex: 1,
    backgroundColor: '#F1F1F1',
  },

  tabBarIcon: {
    width: 22,
    height: 22,
  },
});

export default App;